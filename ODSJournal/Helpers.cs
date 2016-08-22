using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Objects;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Objects;
using ODSJournal.DataModel;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
namespace ODSJournal.Helpers
{
    public static class ComboBoxSearchHelper
    {
        public static void RegisterComboBoxAutocomplete(object sender, string[] source)
        {
            if (sender is System.Windows.Forms.ComboBox)
            {
                if (((System.Windows.Forms.ComboBox)sender).Text.Length >= 1 )
                {
                    string text = ((System.Windows.Forms.ComboBox)sender).Text;
                    if (!string.IsNullOrEmpty(text))
                    {
                        var query = (from src in source
                            where src.ToLowerInvariant().Contains(text.ToLowerInvariant())
                            select src).Distinct();

                        if (query != null)
                        {
                            if (query.Count() > 0)
                            {
                                ComboBoxSearchHelper.PopulateCombo((System.Windows.Forms.ComboBox)sender, query.ToArray());
                                ((System.Windows.Forms.ComboBox)sender).Select(text.Length, 1);
                            }
                        }
                    }
                }
            }
        }

        public static void PopulateCombo(System.Windows.Forms.ComboBox control, string[] p)
        {
            try
            {
                control.Invoke((MethodInvoker)delegate
                {
                    control.BeginUpdate();
                    control.Items.Clear();
                    foreach (string s in p)
                    {
                        control.Items.Add(s);
                    }
                        control.EndUpdate();
                        control.DroppedDown = true;
                });
            }
            catch
            {
                // swallow
            }
        }
    }

    public static class cbxAddressSearchHelper
    {
        public static void Search(ComboBox sender, IEnumerable<ODS_Address> source)
        {
            if (sender.Text.Trim().Length > 0)
            {
                string searchText = sender.Text;
                IEnumerable<ODS_Address> result = source.Where(ODS_Address => ODS_Address.Address.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
                if (result.Count() != 0)
                {
                    sender.Items.Clear();
                    foreach (var a in result)
                    {
                        sender.Items.Add(a.Address.Trim());
                    };
                    sender.DroppedDown = true;
                    sender.SelectionStart = sender.Text.Length;
                    sender.SelectionLength = 0;
                    sender.DroppedDown = true;
                };
            }
            else
            {
                foreach (var a in source)
                {
                    sender.Items.Add(a.Address.Trim());
                };
            };
        }
    }

    public static class LogWriter
    {
        public static void WriteLine(string message)
        {
            if (true)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(@"\\sr-dispdb\\repository\\log\\journal\\" + Environment.MachineName.ToString() + ".html", true, Encoding.UTF8);
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
        public static void WriteErrorReport(string message, int aid, int uid)
        {
            if (true)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(@"\\sr-dispdb\\repository\\log\\journal\\ErrorReporting.html", true, Encoding.UTF8);
                    sw.WriteLine("[ <font color = \"red\"> (Time:) " + DateTime.Now.ToString() + "</font> <font color = \"green\">(Machine:) " + Environment.MachineName +
                        " </font> <font color = \"blue\"(Domain User:)" + Environment.UserDomainName +
                        " </font> <font color = \"orange\"> (Local User:)" + Environment.UserName + "</font> <font color = \"black\">]</font> [AddrId:"+aid.ToString()+";"+uid.ToString()+"] " + message + "<br>");
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
}
