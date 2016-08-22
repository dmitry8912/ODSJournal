using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
using ODSJournal.DataModel;

namespace ODSJournal.Views.Common.Search
{
    public partial class Search : Form
    {
        public int[] AddrIds;
        public int[] AdderIds;
        public int[] CloserIds;
        public int[] ClientIds;
        public int[] ProblemIds;
        public int[] DamageIds;
        public int[] TPIds;
        public int[] UserIds;
        public int[] UchIds;
        public int[] FiderIds;
        public int[] StatIds;
        protected Main parental;
        public Search(Main parental)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.parental = parental;
            this.AcceptButton = btn_Search;
        }


        private void Search_Load(object sender, EventArgs e)
        {
            //this.RefreshClients();
            this.RefreshAddress();
            this.RefreshDamages();
            this.RefreshPowers();
            this.RefreshProblems();
            this.RefreshAdderCloser();
            this.RefreshUchs();
            this.LoadFiders();
            this.LoadStations();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.check_Adder.Checked = false;
            this.check_Address.Checked = false;
            //this.check_Client.Checked = false;
            this.check_Closer.Checked = false;
            this.check_Damage.Checked = false;
            this.check_Problem.Checked = false;
            this.check_TP.Checked = false;
            this.check_DT_Create.Checked = false;
            this.check_DT_Close.Checked = false;
            num_CDay.Value = 1;
            num_CMonth.Value = 1;
            num_CYear.Value = 2013;
            num_ODay.Value = 1;
            num_OMonth.Value = 1;
            num_OYear.Value = 2013;
            cbx_Adder.Items.Clear();
            cbx_Address.Items.Clear();
            //cbx_Client.Items.Clear();
            cbx_Closer.Items.Clear();
            cbx_Damage.Items.Clear();
            cbx_Problem.Items.Clear();
            cbx_TPs.Items.Clear();
        }

        public void RefreshUchs()
        {
            cbx_Uchs.Items.Clear();
            UchModel m = new UchModel();
            var res = m.GetUchs();
            this.UchIds = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Uchs.Items.Add(a.UchName.ToString().Trim());
                this.UchIds[cbx_Uchs.Items.Count - 1] = a.UchId;
            };
        }

        public void RefreshAdderCloser() 
        {
            UserModel m = new UserModel(1);
            var users = m.GetUsers();
            this.UserIds = new int[users.Count()];
            foreach (var a in users)
            {
                cbx_Adder.Items.Add(a.FIO);
                cbx_Closer.Items.Add(a.FIO);
                this.UserIds[cbx_Adder.Items.Count - 1] = a.UserId;
            };

        }
        public void RefreshAddress() 
        {
            AddressModel m = new AddressModel();
            var addr = m.GetAddresses();
            this.AddrIds = new int[addr.Count()];
            foreach (var a in addr)
            {
                cbx_Address.Items.Add(a.Address.ToString().Trim());
                this.AddrIds[cbx_Address.Items.Count - 1] = a.AddressId;
            }
        }
        //public void RefreshClients() 
        //{
        //    ClientsModel m = new ClientsModel();
        //    var c = m.GetClients();
        //    this.ClientIds = new int[c.Count()];
        //    foreach (var a in c)
        //    {
        //        cbx_Client.Items.Add(a.ClientFIO.Trim());
        //        this.ClientIds[cbx_Client.Items.Count - 1] = a.ClientId;
        //    };
        //}
        public void RefreshDamages() 
        {
            DamagesModel dm = new DamagesModel();
            var dList = dm.GetDamages();
            this.DamageIds = new int[dList.Count()];
            foreach (var a in dList)
            {
                cbx_Damage.Items.Add(a.Damage.Trim());
                this.DamageIds[cbx_Damage.Items.Count - 1] = a.DamageId;
            }
        }
        public void RefreshProblems() 
        {
            ProblemsModel m = new ProblemsModel();
            var problems = m.GetProblems();
            this.ProblemIds = new int[problems.Count()];
            foreach (var a in problems)
            {
                cbx_Problem.Items.Add(a.Problem.Trim());
                this.ProblemIds[cbx_Problem.Items.Count - 1] = a.ProblemId;
            }
        }
        public void RefreshPowers() 
        {
            PowersModel m = new PowersModel();
            var tps = m.GetPowers();
            this.TPIds = new int[tps.Count()];
            foreach (var a in tps)
            {
                cbx_TPs.Items.Add(a.Power.Trim());
                this.TPIds[cbx_TPs.Items.Count - 1] = a.PowerId;
            };
        }

        public void LoadStations()
        {
            cbx_Stations.Items.Clear();
            SubstationModel m = new SubstationModel();
            var res = m.GetStations();
            this.StatIds = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Stations.Items.Add(a.SubstationName.Trim());
                this.StatIds[cbx_Stations.Items.Count - 1] = a.SubstationId;
            };
        }

        public void LoadFiders()
        {
            cbx_Fiders.Items.Clear();
            FiderModel m = new FiderModel();
            var res = m.GetFiders();
            this.FiderIds = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Fiders.Items.Add(a.FiderName.Trim());
                this.FiderIds[cbx_Fiders.Items.Count - 1] = a.FiderId;
            };
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ODS_db db = new ODS_db();
            IEnumerable<ODS_Journal> result = db.ODS_Journal;
            DateTime odt = DateTime.Parse(num_ODay.Value.ToString()+"."+num_OMonth.Value.ToString()+"."+num_OYear.Value.ToString());
            DateTime cdt = DateTime.Parse(num_CDay.Value.ToString()+"."+num_CMonth.Value.ToString()+"."+num_CYear.Value.ToString());
            if (check_DT_Create.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.RecieveDate == odt);
            };
            if (check_DT_Close.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.DateComplete == cdt);
            };
            if (check_Adder.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.UserId == this.UserIds[cbx_Adder.SelectedIndex]);
            };
            if (check_Closer.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.ComplUserId == this.UserIds[cbx_Closer.SelectedIndex]);
            };
            if (check_Address.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.AddressId == this.AddrIds[cbx_Address.SelectedIndex]);
            };
            //if (check_Client.Checked)
            //{
            //    result = result.Where(ODS_Journal => ODS_Journal.ClientId == this.ClientIds[cbx_Client.SelectedIndex]);
            //};
            if (check_Problem.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.ProblemId == this.ProblemIds[cbx_Problem.SelectedIndex]);
            };
            if (check_Damage.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.DamageId == this.DamageIds[cbx_Damage.SelectedIndex]);
            };
            if (check_TP.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.PowerId == this.TPIds[cbx_TPs.SelectedIndex]);
            };
            if (check_OnlyOpen.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.ComplUserId == null);
            };
            if (check_OnlyClosed.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.ComplUserId != null);
            };

            if (check_Period.Checked)
            {
                DateTime PeriodStart = DateTime.Parse(num_Per_Start_Day.Value.ToString() + "." + num_Per_Start_Month.Value.ToString() + "." + num_Per_Start_Year.Value.ToString());
                DateTime PeriodEnd = DateTime.Parse(num_Per_End_Day.Value.ToString() + "." + num_Per_End_Month.Value.ToString() + "." + num_Per_End_Year.Value.ToString());
                result = result.Where(ODS_Journal => ODS_Journal.RecieveDate >= PeriodStart && ODS_Journal.RecieveDate <= PeriodEnd);
            }
            if (check_Uch.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.ODS_Address.ODS_Uchs.UchId == this.UchIds[cbx_Uchs.SelectedIndex]);
            };
            if (check_Fider.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.ODS_Powers.ODS_Fidres.FiderId == this.FiderIds[cbx_Fiders.SelectedIndex]);
            };
            if (check_Subs.Checked)
            {
                result = result.Where(ODS_Journal => ODS_Journal.ODS_Powers.ODS_Fidres.ODS_Substations.SubstationId == this.StatIds[cbx_Stations.SelectedIndex]);
            };
            parental.ShowResult(result);
            
            parental.SetJournal(result);
            this.Close();
        }

        private void cbx_Adder_TextChanged(object sender, EventArgs e)
        {
            cbx_Adder.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Adder.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Adder.SelectionLength = 0;
            cbx_Adder.SelectionStart = cbx_Adder.Text.Length;
        }

        private void cbx_Closer_TextChanged(object sender, EventArgs e)
        {
            cbx_Closer.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Closer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Closer.SelectionLength = 0;
            cbx_Closer.SelectionStart = cbx_Closer.Text.Length;
        }

        private void cbx_Address_TextChanged(object sender, EventArgs e)
        {
            cbx_Address.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Address.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Address.SelectionLength = 0;
            cbx_Address.SelectionStart = cbx_Address.Text.Length;
        }

        //private void cbx_Client_TextChanged(object sender, EventArgs e)
        //{
        //    cbx_Client.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    cbx_Client.AutoCompleteSource = AutoCompleteSource.ListItems;
        //    cbx_Client.SelectionLength = 0;
        //    cbx_Client.SelectionStart = cbx_Client.Text.Length;
        //}

        private void cbx_Problem_TextChanged(object sender, EventArgs e)
        {
            cbx_Problem.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Problem.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Problem.SelectionLength = 0;
            cbx_Problem.SelectionStart = cbx_Problem.Text.Length;
        }

        private void cbx_Damage_TextChanged(object sender, EventArgs e)
        {
            cbx_Damage.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Damage.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Damage.SelectionLength = 0;
            cbx_Damage.SelectionStart = cbx_Damage.Text.Length;
        }

        private void cbx_TPs_TextChanged(object sender, EventArgs e)
        {
            cbx_TPs.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_TPs.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_TPs.SelectionLength = 0;
            cbx_TPs.SelectionStart = cbx_TPs.Text.Length;
        }

        private void cbx_Uchs_TextChanged(object sender, EventArgs e)
        {
            cbx_Uchs.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Uchs.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Uchs.SelectionLength = 0;
            cbx_Uchs.SelectionStart = cbx_Uchs.Text.Length;
        }

        private void cbx_Fiders_TextChanged(object sender, EventArgs e)
        {
            cbx_Fiders.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Fiders.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Fiders.SelectionLength = 0;
            cbx_Fiders.SelectionStart = cbx_Fiders.Text.Length;
        }

        private void cbx_Stations_TextChanged(object sender, EventArgs e)
        {
            cbx_Stations.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Stations.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Stations.SelectionLength = 0;
            cbx_Stations.SelectionStart = cbx_Stations.Text.Length;
        }

    }
}
