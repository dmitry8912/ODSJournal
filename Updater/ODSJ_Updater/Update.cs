using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace ODSJ_Updater
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            UpdateConfig.Debug = true;
            LogWriter.WriteLine("<font color = \"red\">Update operation started.</font>");
            Updater u = new Updater();
            this.Hide();
            LogWriter.WriteLine("<font color = \"red\">Update operations ended. Closing.</font>");
            Environment.Exit(0);
        }

        private void Update_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }

    public static class LogWriter
    {
        public static void WriteLine(string message)
        {
            if (UpdateConfig.Debug)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(@"\\sr-dispdb\\repository\\log\\updater\\"+Environment.MachineName.ToString()+".html", true, Encoding.UTF8);
                    sw.WriteLine("[ <font color = \"red\"> (Time:) " + DateTime.Now.ToString() + "</font> <font color = \"green\">(Machine:) " + Environment.MachineName +
                        " </font> <font color = \"blue\"(Domain User:)" + Environment.UserDomainName +
                        " </font> <font color = \"orange\"> (Local User:)" + Environment.UserName + "</font> <font color = \"black\">]</font> " + message + "<br>");
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                }
                catch (Exception ex)
                {

                };
            };
        }
    }

    public static class UpdateConfig
    {
        public static string UpdateServer { get; set; }
        public static string UpdatePath { get; set; }
        public static string LocalCurrentVersion { get; set; }
        public static string RemoteCurrentVersion { get; set; }
        public static string UpdatePackagePath { get; set; }
        public static bool IsUpdateNeeded { get; set; }
        public static bool Debug { get; set; }
    }

    public class Updater
    {
        private int rdepth;
        public Updater()
        {
            this.rdepth = -1;
            this.ReadUpdaterConfig();
            this.ReadLocalVersion();
            this.ReadRemoteVersion();
            this.CompareVersions();
            this.Update();
        }
        public void ReadUpdaterConfig()
        {
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
            if (di.Attributes.HasFlag(FileAttributes.ReadOnly))
            {
                di.Attributes &= ~FileAttributes.ReadOnly;
            };
            StreamReader upd_reader = new StreamReader(Environment.CurrentDirectory+"\\update.ini");
            while (!upd_reader.EndOfStream)
            {
                string str = upd_reader.ReadLine();
                if (str.Count() != 0 && !(str.ElementAt(0) == '#'))
                {
                    if (str.Contains("UPDATE-SERVER"))
                    {
                        int i = str.IndexOf("\"");
                        str = str.Remove(0, i);
                        str = str.Replace("\"", "");
                        UpdateConfig.UpdateServer = str;
                    };
                    if (str.Contains("UPDATE-PATH"))
                    {
                        int i = str.IndexOf("\"");
                        str = str.Remove(0, i);
                        str = str.Replace("\"", "");
                        UpdateConfig.UpdatePath = str;
                    };
                    if (str.Contains("DEBUG"))
                    {
                        int i = str.IndexOf("\"");
                        str = str.Remove(0, i);
                        str = str.Replace("\"", "");
                        if (str == "1")
                        {
                            UpdateConfig.Debug = true;
                        }
                        else
                        {
                            UpdateConfig.Debug = false;
                        };
                    };
                }
            };
            upd_reader.Close();
            upd_reader.Dispose();
            LogWriter.WriteLine("UConf Server:" + UpdateConfig.UpdateServer + " Path:" + UpdateConfig.UpdatePath);

        }
        public void ReadLocalVersion()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal\\version.ini"))
            {
                StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal\\version.ini");
                UpdateConfig.LocalCurrentVersion = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
            }
            else
            {
                UpdateConfig.LocalCurrentVersion = "0";
            };
            LogWriter.WriteLine("LVersion:" + UpdateConfig.LocalCurrentVersion);
        }
        public void ReadRemoteVersion()
        {
            if (File.Exists(@"\\" + UpdateConfig.UpdateServer + "\\" + UpdateConfig.UpdatePath + "\\version.ini"))
            {
                StreamReader sr = new StreamReader(@"\\" + UpdateConfig.UpdateServer + "\\" + UpdateConfig.UpdatePath + "\\version.ini");
                UpdateConfig.RemoteCurrentVersion = sr.ReadToEnd();
                LogWriter.WriteLine("RVersion:" + UpdateConfig.RemoteCurrentVersion);
            }
            else
            {
                UpdateConfig.RemoteCurrentVersion = UpdateConfig.LocalCurrentVersion;
            };
        }
        public void CompareVersions()
        {
            if (UpdateConfig.RemoteCurrentVersion == UpdateConfig.LocalCurrentVersion)
            {
                UpdateConfig.IsUpdateNeeded = false;
            }
            else
            {
                if (Convert.ToDouble(UpdateConfig.LocalCurrentVersion) > Convert.ToDouble(UpdateConfig.RemoteCurrentVersion))
                {
                    UpdateConfig.IsUpdateNeeded = false;
                }
                else
                {
                    UpdateConfig.IsUpdateNeeded = true;
                };
            };
            LogWriter.WriteLine("Need Update:" + UpdateConfig.IsUpdateNeeded.ToString());
        }
        public void Update()
        {
            ++this.rdepth;
            if (this.rdepth >= 3)
            {
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ERR</b></font><font color=\"black\">]</font> Глубина рекурсии >= 3");
                MessageBox.Show("Ошибка обновления.");
                Environment.Exit(0);
            };
            if (UpdateConfig.IsUpdateNeeded)
            {
                LogWriter.WriteLine("Update started");
                string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + @"\\ODS_Journal";
                DirectoryInfo di = new DirectoryInfo(Path);
                DirectoryInfo AppData = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString());
                DirectoryInfo Local = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + @"\\ODS_Journal");
                AppData.Attributes &= ~FileAttributes.ReadOnly;
                if (!di.Exists)
                {
                    Directory.CreateDirectory(Path);
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> Directory ODS_Journal created");
                };
                Local.Attributes &= ~FileAttributes.ReadOnly;
                Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal");
                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal\\bin"))
                {
                    Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal\\bin", true);
                };
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal\\bin");
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> Directory created ODS_Journal\\bin");
                Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal\\bin");
                if (File.Exists(@"\\" + UpdateConfig.UpdateServer + "\\" + UpdateConfig.UpdatePath + "\\" + UpdateConfig.RemoteCurrentVersion + ".zip"))
                {
                    File.Copy(@"\\" + UpdateConfig.UpdateServer + "\\" + UpdateConfig.UpdatePath + "\\" + UpdateConfig.RemoteCurrentVersion + ".zip", UpdateConfig.RemoteCurrentVersion + ".zip", true);
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> Update archive copied successeful");
                }
                else
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ERR</b></font><font color=\"black\">]</font> Update archive NOT EXISTS!");
                };
                if (File.Exists(@"\\" + UpdateConfig.UpdateServer + "\\" + UpdateConfig.UpdatePath + "\\7za.exe"))
                {
                    File.Copy(@"\\" + UpdateConfig.UpdateServer + "\\" + UpdateConfig.UpdatePath + "\\7za.exe", "7za.exe", true);
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> 7za.exe copied successeful");
                }
                else
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ERR</b></font><font color=\"black\">]</font> 7za.exe NOT EXISTS!");
                };
                
                ProcessStartInfo ps = new ProcessStartInfo("7za.exe", "x " + UpdateConfig.RemoteCurrentVersion + ".zip");
                ps.CreateNoWindow = true;
                Process p = new Process();
                p.StartInfo = ps;
                p.Start();
                while (!p.HasExited)
                {

                };
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> Unpack ended");

                try
                {
                    File.Delete(UpdateConfig.RemoteCurrentVersion + ".zip");
                    File.Delete("7za.exe");
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> Files deleted");
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ERR</b></font><font color=\"black\">]</font> Files deleting error:" + ex.Message.ToString());
                };

                Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal");
                try
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + @"\\ODS_Journal\\version.ini");
                    StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + @"\\ODS_Journal\\version.ini",false);
                    sw.Write(UpdateConfig.RemoteCurrentVersion);
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> New version written");
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ERR</b></font><font color=\"black\">]</font> New version write error:" + ex.Message.ToString());
                };
                
                Local.Attributes |= FileAttributes.ReadOnly;
                AppData.Attributes |= FileAttributes.ReadOnly;
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> Directory attributes rewritten");

                try
                {
                    Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal\\bin");
                    ProcessStartInfo ps_ods = new ProcessStartInfo("ODSJournal.exe");
                    Process odsj = new Process();
                    odsj.StartInfo = ps_ods;
                    odsj.Start();
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>OK</b></font><font color=\"black\">]</font> Process started");
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ERR</b></font><font color=\"black\">]</font> Process starting error: " + ex.Message.ToString());
                    LogWriter.WriteLine("Trying to rewrite current local version");
                    UpdateConfig.LocalCurrentVersion = "0";
                    UpdateConfig.IsUpdateNeeded = true;
                    this.Update();
                };
            }
            else
            {
                try
                {
                    Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\ODS_Journal\\bin");
                    ProcessStartInfo ps_ods = new ProcessStartInfo("ODSJournal.exe");
                    Process odsj = new Process();
                    odsj.StartInfo = ps_ods;
                    odsj.Start();
                    LogWriter.WriteLine("No update needed. Process Started.");
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ERR</b></font><font color=\"black\">]</font> Process starting error: " + ex.Message.ToString());
                    LogWriter.WriteLine("Trying to rewrite current local version");
                    UpdateConfig.LocalCurrentVersion = "0";
                    UpdateConfig.IsUpdateNeeded = true;
                    this.Update();
                };
            };
        }
    }


    
}
