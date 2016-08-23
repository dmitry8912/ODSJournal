using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ODSJournal.DataModel;
using ODSJournal.DataModel.Model;

namespace ODSJournal
{
    class Watcher
    {
        private int _lastJid;
        public static Main m;
        private static Watcher _instance;
        public Watcher()
        {

        }
        public static Watcher getInstance()
        {
            if (Watcher._instance == null)
            {
                Watcher._instance = new Watcher();
            };
            return Watcher._instance;
        }

        public void setLastJid(int id)
        {
            this._lastJid = id;
        }

        private void notify()
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Environment.CurrentDirectory + @"\\resources\\system-fault.wav");
            sp.Play();
            sp.Dispose();
            System.Windows.Forms.MessageBox.Show("Создана новая заявка");
            Watcher.m.LoadData();
        }

        public void watch()
        {
            System.Timers.Timer tm = new System.Timers.Timer(5000);
            tm.Elapsed += check;
            tm.Start();
            
        }

        private static void check(object sender, EventArgs e)
        {
            int id = Watcher.getInstance()._lastJid;
            DateTime n = DateTime.Now.Date;
            ODS_db db = new ODS_db();
            var res = db.ODS_Journal.Where(x => x.EntryId > id && x.RecieveDate == n);
            if (res.Count() > 0)
            {
                Watcher.getInstance().setLastJid(res.Max(x => x.EntryId));
                Watcher.getInstance().notify();
            };
        }
    }
}
