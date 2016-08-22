using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.PrintInfo
{
    public partial class PrintInfo : Form
    {
        public PrintInfo(Guid JId)
        {
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            InitializeComponent();
            PrintModel m = new PrintModel(JId, Global.UserId);
            var res = m.GetJournalPrintInfo();
            Tab_Print.Rows.Clear();
            string[] str = new string[2];
            foreach (var a in res)
            {
                str[0] = a.PrintDateTime.ToString();
                str[1] = a.ODS_Users.FIO.ToString().Trim();
                Tab_Print.Rows.Add(str);
            };
        }
    }
}
