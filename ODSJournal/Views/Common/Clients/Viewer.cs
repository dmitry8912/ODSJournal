using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Clients
{
    public partial class Viewer : Form
    {
        protected int id;
        public Viewer()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            toolStrip1.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.LoadData();
        }

        public void LoadData()
        {
            Tab_Clients.Rows.Clear();
            ClientsModel m = new ClientsModel();
            var c = m.GetClients();
            string[] str = new string[9];
            foreach (var a in c)
            {
                str[0] = a.ClientId.ToString();
                str[1] = a.ClientFIO.Trim();
                try
                {
                    str[2] = a.ClientPhone.Trim();
                }
                catch (Exception ex)
                {
                    str[2] = "";
                };
                str[3] = a.ClientHomeNum.ToString();
                str[4] = a.AddressId.ToString();
                try
                {
                    //str[5] = a.ODS_Address.Address.Trim();
                    str[6] = a.Liter.Trim();
                    str[7] = a.Entrance.ToString();
                    str[8] = a.Room.ToString();
                }
                catch (Exception ex)
                {
                    str[5] = "";
                    str[6] = "";
                    str[7] = "";
                    str[8] = "";
                };
                Tab_Clients.Rows.Add(str);
            };
        }

        private void Tool_Load_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor();
            ed.Show();
        }

        private void Tool_Del_Click(object sender, EventArgs e)
        {
            if (!Global.CheckRole((new RoleActionAssign()).ClientDel))
            {
                ClientsModel m = new ClientsModel(this.id);
                m.Delete();
            };
        }

        private void Tab_Clients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.id = Convert.ToInt32(Tab_Clients.Rows[Tab_Clients.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Tab_Clients_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Editor ed = new Editor(Convert.ToInt32(Tab_Clients.Rows[Tab_Clients.SelectedRows[0].Index].Cells[0].Value.ToString()));
                ed.Show();
            }
            catch (Exception ex)
            {
                return;
            };
        }
    }
}
