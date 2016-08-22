using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.Helpers;
namespace ODSJournal
{
    public partial class Error : Form
    {
        public int aid;
        public int uid;
        public Error(int uchId, int AddressId)
        {
            this.aid = AddressId;
            this.uid = uchId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogWriter.WriteErrorReport(textBox1.Text.Trim(), aid, uid);
            this.Close();
        }
    }
}
