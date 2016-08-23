using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ODSJournal.DataModel;
using ODSJournal.DataModel.Model;
using ODSJournal.Views.Common.Address;
using ODSJournal.Helpers;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Tools.Word.Extensions;
using Microsoft.Office.Tools.Word.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
namespace ODSJournal
{
    public partial class Main : Form
    {
        private bool cFlag;
        protected int[] UchIds;
        protected int[] addId;
        protected string[,] addrDetails;
        protected int[] ProblemId;
        protected int[] ClientId;
        protected int[] ObjectIds;

        protected int[] TPIds;
        protected int[] DamageIds;
        protected int[] MonterIds;

        protected string[] addr;

        #region Vars for combobox

        public IEnumerable<ODS_Address> enumOdsAddress;
        public IEnumerable<ODS_Uchs> enumOdsUchs;
        public IEnumerable<ODS_Problems> enumOdsProblems;
        public IEnumerable<ODS_Objects> enumOdsObjects;
        public IEnumerable<ODS_Powers> enumOdsTps;
        public IEnumerable<ODS_Damages> enumOdsDamages;
        public IEnumerable<ODS_Monters> enumOdsMonters;

        public int _addressId;
        public int _uchId;
        public int _problemId;
        public int _objectId;
        public int _tpId;
        public int _damageId;
        public int _monterId;

        #endregion

        public IEnumerable<ODS_Journal> journal;
        public Guid entryId;

        protected Guid eid;
        protected Auth parental;

        public void SetElementSize()
        {
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);           
        }

        public Main(Auth parental)
        {
            InitializeComponent();
            this.RefreshUchList();
            this.RefreshProblemList();
            this.RefreshTPList();
            this.RefreshDamageList();
            this.RefreshUchList();
            this.LoadMonters();
            this.RefreshObjList();

            this._addressId = 0;
            this._tpId = 0;

            this.LoadData();
            if (Global.CheckRole((new RoleActionAssign()).JAdd))
            {
                btn_Add_Addr.Visible = false;
                btn_Add_Problem.Visible = false;
                btn_Damage_Add.Visible = false;
                btn_TP_Add.Visible = false;
                справочникToolStripMenuItem.Visible = false;
                //TPage_AddJEntry.Parent = null;
                btn_Add_Monter.Visible = false;
                btn_Add_Object.Visible = false;
                btn_Add_Uch.Visible = false;
            };
            if (Global.CheckRole((new RoleActionAssign()).AddrAddE))
            {
                btn_Add_Addr.Visible = false;
                btn_Add_Problem.Visible = false;
                btn_Damage_Add.Visible = false;
                btn_TP_Add.Visible = false;
                справочникToolStripMenuItem.Visible = false;
                btn_Add_Monter.Visible = false;
                btn_Add_Object.Visible = false;
                btn_Add_Uch.Visible = false;
            };
            this.parental = parental;
            this.cFlag = true;

            Tab_Journal.Font = new Font(FontFamily.GenericSansSerif, 12);
            this.SetElementSize();
            toolStrip1.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            menuString.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            TPage_CloseEntry.Parent = null; 
            if (Global.CheckRole((new RoleActionAssign()).JAdd))
            {
                TPage_AddJEntry.Parent = null;
            };
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dPanel_user.Text += Global.UserFIO;
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.cFlag)
            {
                Application.Exit();
            };
        }

        #region ToolStrip Menu Actions

        private void адресаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Address.Viewer form = new Viewer();
            form.Show();
        }
        private void участкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ODSJournal.Views.Common.Uchs.Viewer ed = new Views.Common.Uchs.Viewer();
            ed.Show();
        }
        private void поврежденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Damages.Viewer v = new Views.Common.Damages.Viewer();
            v.Show();
        }
        private void источникиПитанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Powers.Viewer v = new Views.Common.Powers.Viewer();
            v.Show();
        }
        private void обращенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Problems.Viewer view = new Views.Common.Problems.Viewer();
            view.Show();
        }
        private void потребителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Clients.Viewer v = new Views.Common.Clients.Viewer();
            v.Show();
        }
        private void выгрузитьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UnloadToExcel(this.journal);
        }
        private void выгрузитьВыделеннуюЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.entryId != null)
            {
                this.UnloadToWord(this.entryId);
            };
        }
        private void подстанцииToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Views.Common.Substations.Viewer v = new Views.Common.Substations.Viewer();
            v.Show();
        }
        private void фидерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Fiders.Viewer v = new Views.Common.Fiders.Viewer();
            v.Show();
        }
        private void монтерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Monters.Viewer v = new Views.Common.Monters.Viewer();
            v.Show();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void сменаПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cFlag = false;
            parental.Relogin();
            this.Close();
            Global.Role = "";
            Global.RoleId = 0;
            Global.UserFIO = "";
            Global.UserId = 0;
        }
        private void найтиЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Search.Search s = new Views.Common.Search.Search(this);
            s.Show();
        }
        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Common.Objects.Viewer v = new Views.Common.Objects.Viewer();
            v.Show();
        }
        
        #endregion  

        #region ButtonClick Actions

        #endregion

        #region cbx_ Refresh Fucntions

        protected void RefreshObjList()
        {
            this.enumOdsObjects = null;
            this.ObjectIds = null;
            cbx_Object.Items.Clear();
            ObjectModel m = new ObjectModel();
            var res = m.GetObjects();
            this.enumOdsObjects = res;
            this.ObjectIds = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Object.Items.Add(a.Object.Trim());
                this.ObjectIds[cbx_Object.Items.Count - 1] = a.ObjectId;
            };
            res = null;
            cbx_Object.SelectedIndex = cbx_Object.Items.IndexOf("Жилой дом");
        }
        protected void RefreshObjListById(int id)
        {
            this.enumOdsObjects = null;
            this.ObjectIds = null;
            cbx_Object.Items.Clear();
            ObjectModel m = new ObjectModel();
            var res = m.GetObjects();
            this.ObjectIds = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Object.Items.Add(a.Object.Trim());
                this.ObjectIds[cbx_Object.Items.Count - 1] = a.ObjectId;
                if (a.ObjectId == id)
                {
                    cbx_Object.SelectedIndex = cbx_Object.Items.Count - 1;
                };
            };
            res = null;
        }
        protected void RefreshAddrList()
        {
            this.enumOdsAddress = null;
            this.addId = null;
            tbx_HNum.Clear();
            cbx_Address.Items.Clear();
            AddressModel am = new AddressModel();
            var addr = am.GetAddressesByUID(this._uchId);
            this.enumOdsAddress = addr;
            foreach (var a in addr)
            {
                cbx_Address.Items.Add(a.Address.ToString().Trim());
            };
            addr = null;
        }
        protected void RefreshProblemList()
        {
            this.enumOdsProblems = null;
            this.ProblemId = null;
            cbx_Problem.Items.Clear();
            ProblemsModel pm = new ProblemsModel();
            var pr = pm.GetProblems();
            this.enumOdsProblems = pr;
            this.ProblemId = new int[pr.Count()];
            foreach (var a in pr)
            {
                cbx_Problem.Items.Add(a.Problem.ToString().Trim());
                this.ProblemId[cbx_Problem.Items.Count - 1] = a.ProblemId;
            };
            pr = null;
        }
        public void RefreshDamageList()
        {
            this.enumOdsDamages = null;
            this.DamageIds = null;
            cbx_Damage.Items.Clear();
            DamagesModel dm = new DamagesModel();
            var damages = dm.GetDamages();
            this.enumOdsDamages = damages;
            this.DamageIds = new int[damages.Count()];
            foreach (var a in damages)
            {
                cbx_Damage.Items.Add(a.Damage.ToString().Trim());
                this.DamageIds[cbx_Damage.Items.Count - 1] = a.DamageId;
            };
            damages = null;
        }
        public void RefreshTPList(int UchId = 0)
        {
            this.enumOdsTps = null;
            this.TPIds = null;
            if (UchId == 0)
            {
                cbx_TPs.Items.Clear();
                PowersModel pm = new PowersModel();
                var powers = pm.GetPowers();
                this.enumOdsTps = powers;
                this.TPIds = new int[powers.Count()];
                foreach (var a in powers)
                {
                    cbx_TPs.Items.Add(a.Power.ToString().Trim());
                    this.TPIds[cbx_TPs.Items.Count - 1] = a.PowerId;
                };
                powers = null;
            }
            else
            {
                cbx_TPs.Items.Clear();
                PowersModel pm = new PowersModel();
                var powers = pm.GetPowerBySubUId(UchId);
                this.enumOdsTps = powers;
                this.TPIds = new int[powers.Count()];
                foreach (var a in powers)
                {
                    cbx_TPs.Items.Add(a.Power.ToString().Trim());
                    this.TPIds[cbx_TPs.Items.Count - 1] = a.PowerId;
                };
                powers = null;
            };
        }
        public void RefreshUchList()
        {
            this.enumOdsUchs = null;
            this.UchIds = null;
            cbx_Uchs.Items.Clear();
            UchModel m = new UchModel();
            var res = m.GetUchs();
            this.enumOdsUchs = res;
            foreach (var a in res)
            {
                cbx_Uchs.Items.Add(a.UchName.Trim());
            };
            res = null;
        }
        public void LoadMonters()
        {
            this.enumOdsMonters = null;
            this.MonterIds = null;
            cbx_Monters.Items.Clear();
            MonterModel m = new MonterModel();
            var res = m.GetMonters();
            this.enumOdsMonters = res;
            this.MonterIds = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Monters.Items.Add(a.MonerFIO.Trim());
                this.MonterIds[cbx_Monters.Items.Count - 1] = a.MonterId;
            };
            res = null;
        }
        public void LoadMonterById(int MonterId)
        {
            this.enumOdsMonters = null;
            this.MonterIds = null;
            cbx_Monters.Items.Clear();
            MonterModel m = new MonterModel();
            var res = m.GetMonters();
            this.enumOdsMonters = res;
            foreach (var a in res)
            {
                cbx_Monters.Items.Add(a.MonerFIO.Trim());
                if (a.MonterId == MonterId)
                {
                    cbx_Monters.SelectedIndex = cbx_Monters.Items.Count - 1;
                };
            };
            res = null;
        }

        public void LoadData()
        {
            db_ctx.RefreshContext();
            Tab_Journal.Rows.Clear();
            JournalModel m = new JournalModel();
            var jEntries = m.GetAllJEntries();
            string[] str;
            this.journal = jEntries;
            foreach (var a in jEntries)
            {
                str = new string[17];
                str[3] = a.JournalId.ToString().Trim();
                str[4] = a.EntryId.ToString().Trim();
                str[5] = a.RecieveDate.ToShortDateString();
                str[6] = a.RecieveTime.ToString().Trim();
                str[7] = a.ODS_Address.ODS_Uchs.UchName.ToString().Trim();
                str[8] = a.ODS_Address.Address.Trim();
                str[9] = a.HNum.ToString().Trim();
                str[10] = a.ODS_Objects.Object.ToString().Trim();
                str[11] = a.ODS_Problems.Problem.ToString().Trim();
                str[12] = a.ClientPlainName.Trim();
                str[13] = a.ClientTelephone.Trim();
                str[14] = a.OpenComment.ToString().Trim();
                str[15] = a.ODS_Users.FIO.ToString().Trim();
                str[16] = "";
                if (a.ComplUserId != null)
                {
                    str[16] = a.ODS_Users1.FIO.ToString().Trim();
                };
                Tab_Journal.Rows.Add(str);
                Application.DoEvents();
            };
            Image warning, def, ok;
            warning = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\warning.png");
            def = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\default.png");
            ok = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\ok.png");
            for (int i = 0; i < Tab_Journal.Rows.Count; i++)
            {
                bool isClosed = false;
                bool isPrinted = false; ;
                bool isOutOfRange = false;
                
                if (Tab_Journal.Rows[i].Cells[16].Value != "")
                {
                    isClosed = true;
                };

                PrintModel pm = new PrintModel(Guid.Parse(Tab_Journal.Rows[i].Cells[3].Value.ToString()), Global.UserId);
                if (pm.isPrinted())
                {
                    isPrinted = true;
                };

                DateTime dt_EntryCreateD = DateTime.Parse(Tab_Journal.Rows[i].Cells[5].Value.ToString() + " " + Tab_Journal.Rows[i].Cells[6].Value.ToString());
                TimeSpan ts_Diff = DateTime.Now - dt_EntryCreateD;
                if (ts_Diff.TotalHours >= 24 && !isClosed)
                {
                    isOutOfRange = true;
                };

                if (isOutOfRange)
                {
                    Tab_Journal.Rows[i].Cells[0].Value = warning;
                } else {
                    Tab_Journal.Rows[i].Cells[0].Value = def;
                };
                if (isClosed)
                {
                    Tab_Journal.Rows[i].Cells[1].Value = ok;
                }
                else
                {
                    Tab_Journal.Rows[i].Cells[1].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\default.png");
                };
                if (isPrinted)
                {
                    Tab_Journal.Rows[i].Cells[2].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\print.png");
                }
                else
                {
                    Tab_Journal.Rows[i].Cells[2].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\default.png");
                };
                Application.DoEvents();
            };
            jEntries = null;
            str = null;

            if (true)
            {
                Watcher.m = this;
                Watcher.getInstance().setLastJid(Convert.ToInt32(Tab_Journal.Rows[0].Cells[4].Value.ToString()));
                Watcher.getInstance().watch();
            };
        }

        #endregion

        #region btn_Refresh_Click

        private void btn_Refresh_Addr_Click(object sender, EventArgs e)
        {
            this.RefreshAddrList();
        }
        private void btn_Refresh_Problem_Click(object sender, EventArgs e)
        {
            this.RefreshProblemList();
        }
        private void btn_TP_Refresh_Click(object sender, EventArgs e)
        {
            this.RefreshTPList(this._uchId);
        }
        private void btn_Damage_Refresh_Click(object sender, EventArgs e)
        {
            this.RefreshDamageList();
        }
        private void btn_Refresh_Monters_Click(object sender, EventArgs e)
        {
            this.LoadMonters();
        }
        private void btn_Refresh_Uchs_Click(object sender, EventArgs e)
        {
            this.RefreshUchList();
        }
        private void btn_ObjRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshObjList();
        }
        private void Tool_Load_Click(object sender, EventArgs e)
        {
            
            //Thread t = new Thread(new ThreadStart(LoadData));
            //t.Start();
            this.LoadData();
        }
        
        #endregion

        #region btn_Add_Click

        private void btn_Add_Addr_Click(object sender, EventArgs e)
        {
            if (cbx_Uchs.SelectedIndex != -1 && cbx_Object.SelectedIndex != -1 && cbx_Address.Text.Trim() != "")
            {
                AddressModel m = new AddressModel(0, this.UchIds[cbx_Uchs.SelectedIndex], cbx_Address.Text);
                m.Add();
                cbx_Address.Text = "";
                this.RefreshAddrList();
            };
        }
        private void btn_Add_Problem_Click(object sender, EventArgs e)
        {
            if (cbx_Problem.Text.Trim() != "")
            {
                ProblemsModel m = new ProblemsModel(0, cbx_Problem.Text.Trim());
                m.Add();
                cbx_Problem.Text = "";
                this.RefreshProblemList();
            };
        }
        private void btn_TP_Add_Click(object sender, EventArgs e)
        {
            Views.Common.TPWizard.Wizard w = new Views.Common.TPWizard.Wizard();
            w.Show();
        }
        private void btn_Damage_Add_Click(object sender, EventArgs e)
        {
            Views.Common.Damages.Editor ed = new Views.Common.Damages.Editor();
            ed.Show();
        }
        private void btn_Add_Monter_Click(object sender, EventArgs e)
        {
            Views.Common.Monters.Editor ed = new Views.Common.Monters.Editor();
            ed.Show();
        }
        private void btn_Add_Uch_Click(object sender, EventArgs e)
        {

        }
        private void btn_Add_Object_Click(object sender, EventArgs e)
        {
            if (cbx_Object.Text != "")
            {
                ObjectModel m = new ObjectModel(0, cbx_Object.Text.Trim());
                m.Add();
                cbx_Object.Text = "";
                this.RefreshObjList();
            };
        }

        #endregion

        #region SelectionChangeCommit Event

        private void cbx_Uchs_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        #endregion

        #region Journal Add\Close Entry

        private void btn_Add_JEntry_Click(object sender, EventArgs e)
        {
            LogWriter.WriteLine("[ADD BTN PRESSED AND LOCKED]");
            btn_Add_JEntry.Enabled = false;
            LogWriter.WriteLine("[Uch PARAM: cbx_Uchs.Text=" + cbx_Uchs.Text.ToString() + "; _addressId=" + this._uchId.ToString() + " ]");
            LogWriter.WriteLine("[ADDR PARAM: cbx_Address.Text="+cbx_Address.Text.ToString()+"; _addressId="+this._addressId.ToString()+" ]");
            if (this._addressId != 0)
            {
                var c = this.enumOdsAddress.Count(ODS_Address => ODS_Address.Address.Trim() == cbx_Address.Text.Trim() && ODS_Address.UchId == this._uchId);
                if (c == 1)
                {
                    var res = this.enumOdsAddress.Single(ODS_Address => ODS_Address.Address.Trim() == cbx_Address.Text.Trim() && ODS_Address.UchId == this._uchId);
                    this._addressId = res.AddressId;
                }
                else
                {
                    MessageBox.Show("Некорректно заполнено поле \"Адрес\"");
                    LogWriter.WriteLine("[ ADDR FIELD WRONG :" + cbx_Address.Text.ToString() + " ]");
                    btn_Add_JEntry.Enabled = true;
                    cbx_Address.Focus();
                    return;
                };
            }
            else
            {
                MessageBox.Show("Не выбран адрес!");
            };

            if (this._objectId == 0)
            {
                var res = this.enumOdsObjects.Single(ODS_Objects => ODS_Objects.Object.Trim() == cbx_Object.Text);
                this._objectId = res.ObjectId;
            };

            if(Global.CheckRole((new RoleActionAssign()).JAdd)) { return; };
            bool flag = false;
            JournalModel m = new JournalModel(this._addressId, this._objectId, tbx_HNum.Text.Trim(), tbx_ClientPlain.Text.Trim(), tbx_Tel.Text.Trim(), this._problemId,Global.UserId,tbx_OComment.Text.Trim());
            LogWriter.WriteLine("[ADDING PRAMETERS: AddId:["+this._addressId.ToString()+"]");
            if (this._problemId != 0 && tbx_HNum.Text.ToString() != "")
            {
                LogWriter.WriteLine("[FIELDS FILL CORRECT]");
                if (m.SearchLast24HoursEntries(this._addressId))
                {
                    DialogResult dResult = MessageBox.Show("По адресу " + cbx_Address.SelectedItem.ToString() + "за последние 24 часа уже были созданы заявки, все равно создать?", "Оповещение о заявках", MessageBoxButtons.YesNo);
                    if (dResult == DialogResult.Yes)
                    {
                        flag = true;
                    }
                    else
                    {
                        this.btn_Add_JEntry.Enabled = true;
                        tbx_Tel.Clear();
                        tbx_HNum.Clear();
                        tbx_OComment.Clear();
                        tbx_ClientPlain.Clear();
                        cbx_Address.Items.Clear();
                        cbx_Address.Text = "";
                        cbx_Uchs.Items.Clear();
                        cbx_Uchs.Text = "";
                        this.RefreshUchList();
                        cbx_Problem.Items.Clear();
                        cbx_Problem.Text = "";
                        this.RefreshProblemList();
                    };
                }
                else
                {
                    flag = true;
                };
            }
            else
            {
                LogWriter.WriteLine("[<b>FIELDS FILL ERROR</b>: ProblemId="+this._problemId.ToString()+"; HNum="+this.tbx_HNum.Text.ToString()+";]");
                MessageBox.Show("Не заполнены необходимые поля!");
                this.btn_Add_JEntry.Enabled = true;
                return;
            };
            if (flag)
            {
                LogWriter.WriteLine("[ADD PENDING...]");
                m.AddEntry();
                tbx_Tel.Clear();
                tbx_HNum.Clear();
                tbx_OComment.Clear();
                tbx_ClientPlain.Clear();
                cbx_Address.Items.Clear();
                cbx_Address.Text = "";
                cbx_Uchs.Items.Clear();
                cbx_Uchs.Text = "";
                this.RefreshUchList();
                cbx_Problem.Items.Clear();
                cbx_Problem.Text = "";
                this.RefreshProblemList();
                LogWriter.WriteLine("[ADD OK, ALL CLEAR]");
                btn_Add_JEntry.Enabled = true;
                MessageBox.Show("Заявка создана!");
                this._addressId = 0;
                this._damageId = 0;
                this._monterId = 0;
                this._objectId = 0;
                this._problemId = 0;
                this._tpId = 0;
                this._uchId = 0;
                this.LoadData();
            };
        }
        private void btn_CloseEntry_Click(object sender, EventArgs e)
        {
            LogWriter.WriteLine("[CLS BTN PRESSED]");
            if (this._tpId == 0)
            {
                var c = this.enumOdsTps.Count(ODS_Powers => ODS_Powers.Power.Trim() == cbx_TPs.Text);
                if (c >= 1)
                {
                    var res = this.enumOdsTps.First(ODS_Powers => ODS_Powers.Power.Trim() == cbx_TPs.Text);
                    this._tpId = res.PowerId;
                }
                else
                {
                    MessageBox.Show("Некорректно заполнено поле \"Источник питания\"");
                    LogWriter.WriteLine("[ TP FIELD WRONG :" + cbx_TPs.Text.ToString() + " ]");
                    cbx_TPs.Focus();
                };
            };

            if (this._monterId == 0)
            {
                var c = this.enumOdsMonters.Count(ODS_Monters => ODS_Monters.MonerFIO.Trim() == cbx_Monters.Text);
                if (c == 1)
                {
                    var res = this.enumOdsMonters.Single(ODS_Monters => ODS_Monters.MonerFIO.Trim() == cbx_Monters.Text);
                    this._monterId = res.MonterId;
                }
                else
                {
                    MessageBox.Show("Некорректно заполнено поле \"Монтер\"");
                    LogWriter.WriteLine("[ MONTER FIELD WRONG :" + cbx_Monters.Text.ToString() + " ]");
                    cbx_Monters.Focus();
                };
            };

            if (this._damageId == 0)
            {
                var c = this.enumOdsDamages.Count(ODS_Damages => ODS_Damages.Damage.Trim() == cbx_Damage.Text);
                if (c == 1)
                {
                    var res = this.enumOdsDamages.Single(ODS_Damages => ODS_Damages.Damage.Trim() == cbx_Damage.Text);
                    this._damageId = res.DamageId;
                }
                else
                {
                    MessageBox.Show("Некорректно заполнено поле \"Повреждение\"");
                    LogWriter.WriteLine("[ DAMAGE FIELD WRONG :" + cbx_Damage.Text.ToString() + " ]");
                    cbx_Damage.Focus();
                };
            };

            if (Global.CheckRole((new RoleActionAssign()).JEditClose)) { return; };
            JournalModel m = new JournalModel();
            if (this._damageId != 0 && this._tpId != 0)
            {
                LogWriter.WriteLine("[CLS PARAMETERS: EiD:["+this.eid.ToString()+"] TPId:["+this._tpId+"]");
                if (
                    m.CloseEntry(this.eid,
                        (num_CD_Day.Value + "." + num_cd_Month.Value + "." + num_CD_Year.Value).ToString(),
                        (num_CT_Hour.Value + ":" + num_CT_Minute.Value).ToString(),
                        this._tpId, this._damageId,
                        tbx_Comment.Text, this._monterId, Global.UserId)
                )
                {
                    MessageBox.Show("Заявка закрыта!");
                    tbx_Comment.Clear();
                    TPage_CloseEntry.Parent = null;
                    cbx_Damage.Items.Clear();
                    this.RefreshDamageList();
                    cbx_TPs.Items.Clear();
                    this.RefreshTPList();
                    LogWriter.WriteLine("[CLS OK, ALL CLEAR]");
                    this._addressId = 0;
                    this._damageId = 0;
                    this._monterId = 0;
                    this._objectId = 0;
                    this._problemId = 0;
                    this._tpId = 0;
                    this._uchId = 0;
                    this.LoadData();
                }
                else
                {
                    MessageBox.Show("Во время закрытия заявки произошла ошибка.");
                };

            }
            else
            {
                MessageBox.Show("Не заполнены обязательне поля!");
            };

        }
        private void btn_SaveEntry_Click(object sender, EventArgs e)
        {
            if (this._objectId == 0)
            {
                var res = this.enumOdsObjects.Single(ODS_Objects => ODS_Objects.Object.Trim() == cbx_Object.Text);
                this._objectId = res.ObjectId;
            };
            if (this._addressId != 0 && this._problemId != 0 && tbx_HNum.Text.Trim() != "")
            {
                JournalModel m = new JournalModel(this._addressId, this._objectId, tbx_HNum.Text.Trim(), tbx_ClientPlain.Text.Trim(), tbx_Tel.Text.Trim(), this._problemId, Global.UserId, tbx_OComment.Text.Trim());
                m.UpdateEntry(this.eid);
                tbx_Tel.Clear();
                tbx_HNum.Clear();
                tbx_OComment.Clear();
                tbx_ClientPlain.Clear();
                cbx_Address.Items.Clear();
                cbx_Address.Text = "";
                cbx_Uchs.Items.Clear();
                cbx_Uchs.Text = "";
                this.RefreshUchList();
                cbx_Problem.Items.Clear();
                cbx_Problem.Text = "";
                this.RefreshProblemList();
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Не заполнены необходимые поля!");
            };
        }
        private void Tab_Journal_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbx_TPs.Text = "";
            cbx_Damage.Text = "";
            cbx_Monters.Text = "";
            tbx_Comment.Text = "";
            this.RefreshDamageList();
            this.LoadMonters();
            try
            {
                this.eid = Guid.Parse(Tab_Journal.Rows[Tab_Journal.SelectedRows[0].Index].Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                return;
            };

            
            JournalModel jrm = new JournalModel();
            var result_entry = jrm.GetEntryById(this.eid);
            this.RefreshTPList(result_entry.ODS_Address.ODS_Uchs.UchId);
            cbx_Uchs.SelectedIndex = cbx_Uchs.Items.IndexOf(result_entry.ODS_Address.ODS_Uchs.UchName.Trim());
            this.RefreshAddrList();
            cbx_Address.SelectedIndex = cbx_Address.Items.IndexOf(result_entry.ODS_Address.Address.Trim());
            cbx_Problem.SelectedIndex = cbx_Problem.Items.IndexOf(result_entry.ODS_Problems.Problem.Trim());
            cbx_Object.SelectedIndex = cbx_Object.Items.IndexOf(result_entry.ODS_Objects.Object.Trim());
            tbx_ClientPlain.Text = result_entry.ClientPlainName.Trim();
            tbx_OComment.Text = result_entry.OpenComment.Trim();
            tbx_HNum.Text = result_entry.HNum.Trim();
            tbx_Tel.Text = result_entry.ClientTelephone.Trim();

            if (Global.RoleId == 1 || Global.RoleId == 11 || Global.RoleId == 12)
            {
                btn_SaveEntry.Visible = true;
            };

            if (Tab_Journal.Rows[Tab_Journal.SelectedRows[0].Index].Cells[16].Value.ToString() == "")
            {
                TPage_CloseEntry.Parent = TabC_Journal;
                TabC_Journal.SelectedTab = TPage_CloseEntry;
                num_CD_Day.Value = Convert.ToInt32(DateTime.Now.Day);
                num_cd_Month.Value = Convert.ToInt32(DateTime.Now.Month);
                num_CD_Year.Value = Convert.ToInt32(DateTime.Now.Year);
                num_CT_Hour.Value = DateTime.Now.Hour;
                num_CT_Minute.Value = DateTime.Now.Minute;
                cbx_TPs.Text = "";
                cbx_Damage.Text = "";
                cbx_Monters.Text = "";
                tbx_Comment.Text = "";
                this.RefreshDamageList();
                this.RefreshTPList(result_entry.ODS_Address.ODS_Uchs.UchId);
                this.LoadMonters();
                btn_CloseEntry.Enabled = true;
            }
            else
            {
                if (Global.CheckRole((new RoleActionAssign()).JEditClose))
                {
                    TPage_CloseEntry.Parent = TabC_Journal;
                    TabC_Journal.SelectedTab = TPage_CloseEntry;
                    JournalModel jm = new JournalModel();
                    var entry = jm.GetEntryById(this.eid);
                    num_CD_Day.Value = entry.DateComplete.Value.Day;
                    num_cd_Month.Value = entry.DateComplete.Value.Month;
                    num_CD_Year.Value = entry.DateComplete.Value.Year;
                    num_CT_Hour.Value = entry.TimeComplete.Value.Hours;
                    num_CT_Minute.Value = entry.TimeComplete.Value.Minutes;
                    cbx_Damage.SelectedIndex = cbx_Damage.Items.IndexOf(entry.ODS_Damages.Damage.Trim());
                    this.RefreshTPList(result_entry.ODS_Address.ODS_Uchs.UchId);
                    cbx_TPs.SelectedIndex = cbx_TPs.Items.IndexOf(entry.ODS_Powers.Power.Trim());
                    tbx_Comment.Text = entry.Comment;
                    this.LoadMonterById(Convert.ToInt32(entry.MonterId.ToString()));
                    btn_CloseEntry.Enabled = false;
                }
                else
                {
                    TPage_CloseEntry.Parent = TabC_Journal;
                    TabC_Journal.SelectedTab = TPage_CloseEntry;
                    JournalModel jm = new JournalModel();
                    var entry = jm.GetEntryById(this.eid);
                    num_CD_Day.Value = entry.DateComplete.Value.Day;
                    num_cd_Month.Value = entry.DateComplete.Value.Month;
                    num_CD_Year.Value = entry.DateComplete.Value.Year;
                    num_CT_Hour.Value = entry.TimeComplete.Value.Hours;
                    num_CT_Minute.Value = entry.TimeComplete.Value.Minutes;
                    cbx_Damage.SelectedIndex = cbx_Damage.Items.IndexOf(entry.ODS_Damages.Damage.Trim());
                    cbx_TPs.SelectedIndex = cbx_TPs.Items.IndexOf(entry.ODS_Powers.Power.Trim());
                    tbx_Comment.Text = entry.Comment;
                    this.LoadMonterById(Convert.ToInt32(entry.MonterId.ToString()));
                }
            };
        }

        #endregion

        #region Unload Functions

        public void ShowResult(IEnumerable<ODS_Journal> jEntries)
        {
            Tab_Journal.Rows.Clear();
            string[] str;
            foreach (var a in jEntries)
            {
                str = new string[17];
                str[3] = a.JournalId.ToString().Trim();
                str[4] = a.EntryId.ToString().Trim();
                str[5] = a.RecieveDate.ToShortDateString();
                str[6] = a.RecieveTime.ToString().Trim();
                str[7] = a.ODS_Address.ODS_Uchs.UchName.ToString().Trim();
                str[8] = a.ODS_Address.Address.Trim();
                str[9] = a.HNum.ToString().Trim();
                str[10] = a.ODS_Objects.Object.ToString().Trim();
                str[11] = a.ODS_Problems.Problem.ToString().Trim();
                str[12] = a.ClientPlainName.Trim();
                str[13] = a.ClientTelephone.Trim();
                str[14] = a.OpenComment.ToString().Trim();
                str[15] = a.ODS_Users.FIO.ToString().Trim();
                str[16] = "";
                if (a.ComplUserId != null)
                {
                    str[16] = a.ODS_Users1.FIO.ToString().Trim();
                };
                Tab_Journal.Rows.Add(str);
            };
            for (int i = 0; i < Tab_Journal.Rows.Count; i++)
            {
                bool isClosed = false;
                bool isPrinted = false; ;
                bool isOutOfRange = false;

                if (Tab_Journal.Rows[i].Cells[16].Value != "")
                {
                    isClosed = true;
                };

                PrintModel pm = new PrintModel(Guid.Parse(Tab_Journal.Rows[i].Cells[3].Value.ToString()), Global.UserId);
                if (pm.isPrinted())
                {
                    isPrinted = true;
                };

                DateTime dt_EntryCreateD = DateTime.Parse(Tab_Journal.Rows[i].Cells[5].Value.ToString() + " " + Tab_Journal.Rows[i].Cells[6].Value.ToString());
                TimeSpan ts_Diff = DateTime.Now - dt_EntryCreateD;
                if (ts_Diff.TotalHours >= 24 && !isClosed)
                {
                    isOutOfRange = true;
                };

                if (isOutOfRange)
                {
                    Tab_Journal.Rows[i].Cells[0].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\warning.png");
                }
                else
                {
                    Tab_Journal.Rows[i].Cells[0].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\default.png");
                };
                if (isClosed)
                {
                    Tab_Journal.Rows[i].Cells[1].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\ok.png");
                }
                else
                {
                    Tab_Journal.Rows[i].Cells[1].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\default.png");
                };
                if (isPrinted)
                {
                    Tab_Journal.Rows[i].Cells[2].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\print.png");
                }
                else
                {
                    Tab_Journal.Rows[i].Cells[2].Value = Image.FromFile(Environment.CurrentDirectory + @"\\resources\\icons\\default.png");
                };

            };
        }
        public void UnloadToExcel(IEnumerable<ODS_Journal> jEntries)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = false;
            excelApp.Workbooks.Add();
            Excel.Worksheet _workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            string[] hStr = { 
                                "№ заявки", "Дата принятия", "Время принятия",
                                "Участок", "Адрес", "№ дома", "Объект",
                                "Обращение", "Потребитель", "Телефон потребителя", "Примечание",
                                "Принявший",
                                "Дата выполнения", "Время выполнения",
                                "Подстанция", "Фидер", "ТП",
                                "Характер повреждения",
                                "Примечание", "Монтер", "Закрывший"
                            };

            #region ExcelHeader

            _workSheet.Cells[1, "A"] = hStr[0];
            _workSheet.Cells[1, "B"] = hStr[1];
            _workSheet.Cells[1, "C"] = hStr[2];
            _workSheet.Cells[1, "D"] = hStr[3];
            _workSheet.Cells[1, "E"] = hStr[4];
            _workSheet.Cells[1, "F"] = hStr[5];
            _workSheet.Cells[1, "G"] = hStr[6];
            _workSheet.Cells[1, "H"] = hStr[7];
            _workSheet.Cells[1, "I"] = hStr[8];
            _workSheet.Cells[1, "J"] = hStr[9];
            _workSheet.Cells[1, "K"] = hStr[10];
            _workSheet.Cells[1, "L"] = hStr[11];
            _workSheet.Cells[1, "M"] = hStr[12];
            _workSheet.Cells[1, "N"] = hStr[13];
            _workSheet.Cells[1, "O"] = hStr[14];
            _workSheet.Cells[1, "P"] = hStr[15];
            _workSheet.Cells[1, "Q"] = hStr[16];
            _workSheet.Cells[1, "R"] = hStr[17];
            _workSheet.Cells[1, "S"] = hStr[18];
            _workSheet.Cells[1, "T"] = hStr[19];
            _workSheet.Cells[1, "U"] = hStr[20];

            #endregion

            string[] str = new string[21];
            int i = 2;
            Progress p = new Progress(Convert.ToInt32(jEntries.Count().ToString()));
            p.Show();
            foreach (var a in jEntries)
            {
                str = new string[21];
                _workSheet.Cells[i, "A"] = a.EntryId.ToString().Trim();
                _workSheet.Cells[i, "B"] = a.RecieveDate.Day.ToString() + "." + a.RecieveDate.Month.ToString() + "." + a.RecieveDate.Year.ToString();
                _workSheet.Cells[i, "C"] = a.RecieveTime.ToString().Trim();
                _workSheet.Cells[i, "D"] = a.ODS_Address.ODS_Uchs.UchName.Trim();
                _workSheet.Cells[i, "E"] = a.ODS_Address.Address.Trim();
                _workSheet.Cells[i, "F"] = a.HNum.ToString().Trim();
                _workSheet.Cells[i, "G"] = a.ODS_Objects.Object.Trim();
                _workSheet.Cells[i, "H"] = a.ODS_Problems.Problem.Trim();
                _workSheet.Cells[i, "I"] = a.ClientPlainName.Trim();
                _workSheet.Cells[i, "J"] = a.ClientTelephone.ToString().Trim();
                _workSheet.Cells[i, "K"] = a.OpenComment.Trim();
                _workSheet.Cells[i, "L"] = a.ODS_Users.FIO.ToString().Trim();
                if (a.ComplUserId != null)
                {
                    _workSheet.Cells[i, "M"] = a.DateComplete.Value.Day.ToString() + "." + a.DateComplete.Value.Month.ToString() + "." + a.DateComplete.Value.Year.ToString();
                    _workSheet.Cells[i, "N"] = a.TimeComplete.ToString();
                    _workSheet.Cells[i, "O"] = a.ODS_Powers.ODS_Fidres.ODS_Substations.SubstationName.Trim();
                    _workSheet.Cells[i, "P"] = a.ODS_Powers.ODS_Fidres.FiderName.Trim();
                    _workSheet.Cells[i, "Q"] = a.ODS_Powers.Power.Trim();
                    _workSheet.Cells[i, "R"] = a.ODS_Damages.Damage.Trim();
                    _workSheet.Cells[i, "S"] = a.Comment.ToString().Trim();
                    _workSheet.Cells[i, "T"] = a.ODS_Monters.MonerFIO.Trim();
                    _workSheet.Cells[i, "U"] = a.ODS_Users1.FIO.Trim();
                };
                ++i;
                p.MoveProgress(1);
            };

            _workSheet.Range["A1:U" + (i - 1).ToString()].Select();
            excelApp.Selection.HorizontalAlignment = -4108;
            excelApp.Selection.Borders.LineStyle = 1;
            excelApp.Selection.Borders.Weight = 2;
            excelApp.Selection.Font.Name = "Times New Roman";
            excelApp.Selection.Font.Size = 12;
            excelApp.ActiveSheet.PageSetup.Orientation = 2;
            for (int a = 1; a <= 21; a++)
            {
                _workSheet.Columns[a].AutoFit();
            };
            p.Close();
            excelApp.Visible = true;
        }
        public void SetJournal(IEnumerable<ODS_Journal> result)
        {
            this.journal = result;
        }
        private void Tab_Journal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.entryId = Guid.Parse(Tab_Journal.Rows[Tab_Journal.SelectedRows[0].Index].Cells[3].Value.ToString());
                if (e.Button == MouseButtons.Right)
                {
                    Views.Common.PrintInfo.PrintInfo pi = new Views.Common.PrintInfo.PrintInfo(this.entryId);
                    pi.Show();
                };
            }
            catch (Exception ex)
            {

            };
            
        }
        public void UnloadToWord(Guid EntryId)
        {
            JournalModel m = new JournalModel();
            var j = m.GetEntryById(EntryId);
            var eWord = new Word.Application();
            eWord.Application.Documents.Add(Environment.CurrentDirectory+"\\template.dot");
            
            eWord.Application.ActiveDocument.Bookmarks["EntryNum"].Range.Text = j.EntryId.ToString();
            eWord.Application.ActiveDocument.Bookmarks["RDate"].Range.Text = j.RecieveDate.Day.ToString() + "." + j.RecieveDate.Month.ToString() + "." + j.RecieveDate.Year.ToString();
            eWord.Application.ActiveDocument.Bookmarks["RTime"].Range.Text = j.RecieveTime.ToString();
            eWord.Application.ActiveDocument.Bookmarks["Address"].Range.Text = j.ODS_Address.Address.ToString().Trim();
            eWord.Application.ActiveDocument.Bookmarks["HNum"].Range.Text = j.HNum.ToString().Trim();
            eWord.Application.ActiveDocument.Bookmarks["Object"].Range.Text = j.ODS_Objects.Object.Trim();
            eWord.Application.ActiveDocument.Bookmarks["ClientPlain"].Range.Text = j.ClientPlainName.Trim();
            eWord.Application.ActiveDocument.Bookmarks["CPhone"].Range.Text = j.ClientTelephone.Trim();
            eWord.Application.ActiveDocument.Bookmarks["Problem"].Range.Text = j.ODS_Problems.Problem.ToString().Trim();
            eWord.Application.ActiveDocument.Bookmarks["User"].Range.Text = j.ODS_Users.FIO.Trim();
            eWord.Application.ActiveDocument.Bookmarks["OComment"].Range.Text = j.OpenComment.Trim().ToString();

            eWord.Application.Visible = true;

            PrintModel pm = new PrintModel(j.JournalId,Global.UserId);
            pm.AddPritInfo();
            m = null;
            j = null;
            pm = null;
        }

        #endregion

        #region KeyUp Events

        private void cbx_Address_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((System.Windows.Forms.ComboBox)sender).Text.Trim().Length > 0)
                {
                    string searchText = ((System.Windows.Forms.ComboBox)sender).Text;
                    IEnumerable<ODS_Address> result = this.enumOdsAddress.Where(ODS_Address => ODS_Address.Address.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
                    if (result.Count() != 0)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Clear();
                        foreach (var a in result)
                        {
                            ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Address.Trim());
                        };
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                        ((System.Windows.Forms.ComboBox)sender).SelectionStart = ((System.Windows.Forms.ComboBox)sender).Text.Length;
                        ((System.Windows.Forms.ComboBox)sender).SelectionLength = 0;
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                    };
                }
                else
                {
                    foreach (var a in this.enumOdsAddress)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Address.Trim());
                    };
                };
            };
        }
        private void cbx_Uchs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((System.Windows.Forms.ComboBox)sender).Text.Trim().Length > 0)
                {
                    
                    string searchText = ((System.Windows.Forms.ComboBox)sender).Text;
                    IEnumerable<ODS_Uchs> result = this.enumOdsUchs.Where(ODS_Uchs => ODS_Uchs.UchName.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
                    if (result.Count() != 0)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Clear();
                        foreach (var a in result)
                        {
                            ((System.Windows.Forms.ComboBox)sender).Items.Add(a.UchName.Trim());
                        };
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                        ((System.Windows.Forms.ComboBox)sender).SelectionStart = ((System.Windows.Forms.ComboBox)sender).Text.Length;
                        ((System.Windows.Forms.ComboBox)sender).SelectionLength = 0;
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                    };
                }
                else
                {
                    foreach (var a in this.enumOdsUchs)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Add(a.UchName.Trim());
                    };
                };
            };
        }
        private void cbx_Problem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((System.Windows.Forms.ComboBox)sender).Text.Trim().Length > 0)
                {
                    
                    string searchText = ((System.Windows.Forms.ComboBox)sender).Text;
                    IEnumerable<ODS_Problems> result = this.enumOdsProblems.Where(ODS_Problems => ODS_Problems.Problem.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
                    if (result.Count() != 0)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Clear();
                        foreach (var a in result)
                        {
                            ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Problem.Trim());
                        };
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                        ((System.Windows.Forms.ComboBox)sender).SelectionStart = ((System.Windows.Forms.ComboBox)sender).Text.Length;
                        ((System.Windows.Forms.ComboBox)sender).SelectionLength = 0;
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                    };
                }
                else
                {
                    foreach (var a in this.enumOdsProblems)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Problem.Trim());
                    };
                };
            };
        }
        private void cbx_Object_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((System.Windows.Forms.ComboBox)sender).Text.Trim().Length > 0)
                {

                    string searchText = ((System.Windows.Forms.ComboBox)sender).Text;
                    IEnumerable<ODS_Objects> result = this.enumOdsObjects.Where(ODS_Objects => ODS_Objects.Object.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
                    if (result.Count() != 0)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Clear();
                        foreach (var a in result)
                        {
                            ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Object.Trim());
                        };
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                        ((System.Windows.Forms.ComboBox)sender).SelectionStart = ((System.Windows.Forms.ComboBox)sender).Text.Length;
                        ((System.Windows.Forms.ComboBox)sender).SelectionLength = 0;
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                    };
                }
                else
                {
                    foreach (var a in this.enumOdsObjects)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Object.Trim());
                    };
                };
            };
        }
        private void cbx_TPs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((System.Windows.Forms.ComboBox)sender).Text.Trim().Length > 0)
                {

                    string searchText = ((System.Windows.Forms.ComboBox)sender).Text;
                    IEnumerable<ODS_Powers> result = this.enumOdsTps.Where(ODS_Powers => ODS_Powers.Power.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
                    if (result.Count() != 0)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Clear();
                        foreach (var a in result)
                        {
                            ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Power.Trim());
                        };
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                        ((System.Windows.Forms.ComboBox)sender).SelectionStart = ((System.Windows.Forms.ComboBox)sender).Text.Length;
                        ((System.Windows.Forms.ComboBox)sender).SelectionLength = 0;
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                    };
                }
                else
                {
                    foreach (var a in this.enumOdsTps)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Power.Trim());
                    };
                };
            };
        }
        private void cbx_Damage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((System.Windows.Forms.ComboBox)sender).Text.Trim().Length > 0)
                {

                    string searchText = ((System.Windows.Forms.ComboBox)sender).Text;
                    IEnumerable<ODS_Damages> result = this.enumOdsDamages.Where(ODS_Damages => ODS_Damages.Damage.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
                    if (result.Count() != 0)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Clear();
                        foreach (var a in result)
                        {
                            ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Damage.Trim());
                        };
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                        ((System.Windows.Forms.ComboBox)sender).SelectionStart = ((System.Windows.Forms.ComboBox)sender).Text.Length;
                        ((System.Windows.Forms.ComboBox)sender).SelectionLength = 0;
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                    };
                }
                else
                {
                    foreach (var a in this.enumOdsDamages)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Add(a.Damage.Trim());
                    };
                };
            };
        }
        private void cbx_Monters_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((System.Windows.Forms.ComboBox)sender).Text.Trim().Length > 0)
                {

                    string searchText = ((System.Windows.Forms.ComboBox)sender).Text;
                    IEnumerable<ODS_Monters> result = this.enumOdsMonters.Where(ODS_Monters => ODS_Monters.MonerFIO.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
                    if (result.Count() != 0)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Clear();
                        foreach (var a in result)
                        {
                            ((System.Windows.Forms.ComboBox)sender).Items.Add(a.MonerFIO.Trim());
                        };
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                        ((System.Windows.Forms.ComboBox)sender).SelectionStart = ((System.Windows.Forms.ComboBox)sender).Text.Length;
                        ((System.Windows.Forms.ComboBox)sender).SelectionLength = 0;
                        ((System.Windows.Forms.ComboBox)sender).DroppedDown = true;
                    };
                }
                else
                {
                    foreach (var a in this.enumOdsMonters)
                    {
                        ((System.Windows.Forms.ComboBox)sender).Items.Add(a.MonerFIO.Trim());
                    };
                };
            };
        }

        #endregion

        #region SelectedIndex Changed Event Handlers

        private void cbx_Uchs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                var res = this.enumOdsUchs.Single(ODS_Uchs => ODS_Uchs.UchName.Trim() == cbx_Uchs.Text);
                this._uchId = res.UchId;
                this.RefreshAddrList();
            }
            catch (Exception ex)
            {
                
            };
            
        }
        private void cbx_Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogWriter.WriteLine("[SelectedIndexChanged Event: AddressText:" + cbx_Address.Text.ToString() + "UchId:" + this._uchId.ToString() + "]");
            try
            {
                if (this._uchId != 0)
                {
                    var res = this.enumOdsAddress.Single(ODS_Address => ODS_Address.Address.Trim() == cbx_Address.Text.Trim() && ODS_Address.UchId == this._uchId);
                    this._addressId = res.AddressId;
                }
                else
                {
                    MessageBox.Show("Выберите участок заново!");
                };
            }
            catch (Exception ex)
            {
                LogWriter.WriteLine("[SelectedIndexChanged Event: Error:" + ex.InnerException.ToString() + "]");
            };
            LogWriter.WriteLine("[SelectedIndexChanged Event: Assigned AddressId:" + this._addressId.ToString() + "]");
        }
        private void cbx_Problem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var res = this.enumOdsProblems.Single(ODS_Problems => ODS_Problems.Problem.Trim() == cbx_Problem.Text.Trim());
                this._problemId = res.ProblemId;
            }
            catch (Exception ex)
            {

            };
        }
        private void cbx_Object_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var res = this.enumOdsObjects.Single(ODS_Objects => ODS_Objects.Object.Trim() == cbx_Object.Text);
                this._objectId = res.ObjectId;
            }
            catch (Exception ex)
            {

            };
        }
        private void cbx_TPs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var res = this.enumOdsTps.Single(ODS_Powers => ODS_Powers.Power.Trim() == cbx_TPs.Text);
                this._tpId = res.PowerId;
            }
            catch (Exception ex)
            {
                JournalModel jrm = new JournalModel();
                var result_entry = jrm.GetEntryById(this.eid);
                this._tpId = Convert.ToInt32(result_entry.PowerId.ToString());
            };
        }
        private void cbx_Damage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var res = this.enumOdsDamages.Single(ODS_Damages => ODS_Damages.Damage.Trim() == cbx_Damage.Text);
                this._damageId = res.DamageId;
            }
            catch (Exception ex)
            {

            };
        }
        private void cbx_Monters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var res = this.enumOdsMonters.Single(ODS_Monters => ODS_Monters.MonerFIO.Trim() == cbx_Monters.Text);
                this._monterId = res.MonterId;
            }
            catch (Exception ex)
            {

            };
        }

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Error err = new Error(this._uchId, this._addressId);
            err.Show();
        }

        private void Tab_Journal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
