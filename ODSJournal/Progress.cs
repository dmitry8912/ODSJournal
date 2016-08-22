using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ODSJournal
{
    public partial class Progress : Form
    {
        public int count;
        public Progress(int count)
        {
            InitializeComponent();
            this.count = count;
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            pBar.Maximum = this.count;
        }
        public void MoveProgress(int value)
        {
            pBar.Value += value;
        }
    }
}
