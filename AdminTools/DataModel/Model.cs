using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Objects;
using AdminTools.DataModel;
using System.Security.Cryptography;
using System.Windows.Forms;
using AdminTools.DataModel;
namespace AdminTools.DataModel
{
    namespace Model
    {
        public static class Global
        {
            public static int UserId { get; set; }
            public static int RoleId { get; set; }
            public static string Role { get; set; }
            public static string UserFIO { get; set; }
            public static bool CheckRole(int[] Array)
            {
                if (!Array.Contains(Global.RoleId))
                {
                    MessageBox.Show("Недостаточно прав для выполнения этой операции!");
                    return true;
                }
                else
                {
                    return false;
                };
            }
        }

        public class RoleActionAssign
        {
            public readonly int[] AddrAddE = { 1, 2 };
            public readonly int[] AddrDel = {  1, 2 };

            public readonly int[] ClientAddE = { 1, 2 };
            public readonly int[] ClientDel = { 1, 2 };

            public readonly int[] DamageAddE = { 1, 2 };
            public readonly int[] DamageDel = { 1, 2 };

            public readonly int[] PowerAddE = { 1, 2 };
            public readonly int[] PowerDel = { 1, 2 };

            public readonly int[] ProblemAddE = { 1, 2 };
            public readonly int[] ProblemDel = { 1, 2 };

            public readonly int[] UchAddE = { 1, 2 };
            public readonly int[] UchDel = { 1, 2 };

            public readonly int[] JAdd = { 1, 2 };
            public readonly int[] JEditClose = { 1, 2 };
            public readonly int[] JDel = { 1, 2 };

            public readonly int[] UnloadInfo = { 1, 2 };
            public readonly int[] Print = { 1, 2 };
        }

        class RoleModel
        {
            private int RoleId;
            private string RoleName;
            private ODS_db db;
            public RoleModel(int RoleId = 0, string RoleName = "")
            {
                this.RoleId = RoleId;
                this.RoleName = RoleName;
                this.db = new ODS_db();
            }

            public bool AddRole()
            {
                try
                {
                    ODS_Roles r = new ODS_Roles();
                    r.Role = this.RoleName;
                    db.ODS_Roles.AddObject(r);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool EditRole()
            {
                try
                {
                    var Role = db.ODS_Roles.Single(ODS_Roles => ODS_Roles.RoleId == this.RoleId);
                    Role.Role = this.RoleName;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            public bool DeleteRole()
            {
                try
                {
                    var Role = db.ODS_Roles.Single(ODS_Roles => ODS_Roles.RoleId == this.RoleId);
                    db.DeleteObject(Role);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            public IEnumerable<ODS_Roles> GetRoles()
            {
                return db.ODS_Roles;
            }
        }

        class UserModel
        {
            private int UserId;
            private int RoleId;
            private string RoleName;
            private string UserName;
            private string Password;
            private string ViewName;
            private string MonterName;
            private string MonterPhone;
            
            //Для авторизации\смены пароля
            public UserModel(string UserName, string PlainPassword, int UserId = 0)
            {
                this.UserName = UserName;
                this.Password = this.GetHash(PlainPassword);
                this.UserId = UserId;
            }

            //Для добавления\изменения данных пользователя
            public UserModel(string UserName, string PlainPassword, string VName, int Role = 0)
            {
                this.UserName = UserName;
                this.Password = this.GetHash(PlainPassword);
                this.ViewName = VName;
                this.RoleId = Role;
            }

            public UserModel(int UserId, string UserName, string VName, int Role = 0)
            {
                this.UserName = UserName;
                this.UserId = UserId;
                this.ViewName = VName;
                this.RoleId = Role;
            }

            //Для удаления
            public UserModel(int UserId)
            {
                this.UserId = UserId;
            }

            protected string GetHash(string input)
            {
                MD5 hash = MD5.Create();
                byte[] data = hash.ComputeHash(Encoding.Default.GetBytes(input));
                StringBuilder s = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    s.Append(data[i].ToString("x2"));
                };
                return s.ToString();
            }

            public bool AddNewUser()
            {
                ODS_db db = new ODS_db();
                ODS_Users user = new ODS_Users();
                user.Login = this.UserName;
                user.Password = this.Password;
                user.FIO = this.ViewName;
                user.RoleId = this.RoleId;
                try
                {
                    db.ODS_Users.AddObject(user);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool ChangeUserPassword()
            {
                ODS_db db = new ODS_db();
                var user = new ODS_Users();
                try
                {
                    user = db.ODS_Users.SingleOrDefault(ODS_Users => ODS_Users.UserId == this.UserId);
                    user.Password = this.Password;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool ModifyUserData()
            {
                ODS_db db = new ODS_db();
                var user = new ODS_Users();
                try
                {
                    user = db.ODS_Users.SingleOrDefault(ODS_Users => ODS_Users.UserId == this.UserId);
                    user.Login = this.UserName;
                    user.FIO = this.ViewName;
                    user.RoleId = this.RoleId;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool DeleteUser()
            {
                ODS_db db = new ODS_db();
                var user = new ODS_Users();
                try
                {
                    user = db.ODS_Users.SingleOrDefault(ODS_Users => ODS_Users.UserId == this.UserId);
                    db.ODS_Users.DeleteObject(user);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool AuthUser()
            {
                ODS_db db = new ODS_db();
                var user = new ODS_Users();
                string usern, pass;
                usern = this.UserName;
                pass = this.Password;
                try
                {
                    user = db.ODS_Users.Single(ODS_Users => ODS_Users.Login == usern && ODS_Users.Password == pass);
                }
                catch (Exception ex)
                {
                    return false;
                };
                if (user.UserId != null)
                {
                    return true;
                };
                return true;
            }
            public bool AddMonter(string MonterFIO, string MonterPhone)
            {
                ODS_db db = new ODS_db();
                var user = new ODS_Users();
                try
                {
                    user = db.ODS_Users.SingleOrDefault(ODS_Users => ODS_Users.UserId == this.UserId);
                    user.MonterFIO = MonterFIO;
                    user.MonterPhone = MonterPhone;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public ODS_Users GetUser()
            {
                ODS_db db = new ODS_db();
                try
                {
                    return db.ODS_Users.Single(ODS_Users => ODS_Users.Login == this.UserName && ODS_Users.Password == this.Password);
                }
                catch (Exception ex)
                {
                    return null;
                };
            }

            public ODS_Users GetUserById()
            {
                ODS_db db = new ODS_db();
                try
                {
                    return db.ODS_Users.Single(ODS_Users => ODS_Users.UserId == this.UserId);
                }
                catch (Exception ex)
                {
                    return null;
                };
            }

            public void GlobalUser()
            {
                ODS_db db = new ODS_db();
                var u = db.ODS_Users.Single(ODS_Users => ODS_Users.Login == this.UserName && ODS_Users.Password == this.Password);
                Global.UserId = u.UserId;
                Global.UserFIO = u.FIO;
                Global.RoleId = u.RoleId;
                Global.Role = u.ODS_Roles.Role;
            }

            public IEnumerable<ODS_Users> GetUsers()
            {
                ODS_db db = new ODS_db();
                return db.ODS_Users;
            }
        }
        
        class UchModel
        {
            private ODS_db db;
            private int UchId;
            private string UchName;
            public UchModel(int id = 0,string UchName= "")
            {
                this.UchId = id;
                this.UchName = UchName;
                db = new ODS_db();
            }

            public IEnumerable<ODS_Uchs> GetUchs()
            {
                return db.ODS_Uchs;
            }

            public bool Add()
            {
                ODS_Uchs u = new ODS_Uchs();
                u.UchName = this.UchName;
                try
                {
                    db.ODS_Uchs.AddObject(u);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool Change()
            {
                var u = new ODS_Uchs();
                try
                {
                    u = db.ODS_Uchs.SingleOrDefault(ODS_Uchs => ODS_Uchs.UchId == this.UchId);
                    u.UchName = this.UchName;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool Delete()
            {
                try
                {
                    var u = db.ODS_Uchs.SingleOrDefault(ODS_Uchs => ODS_Uchs.UchId == this.UchId);
                    db.ODS_Uchs.DeleteObject(u);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
        }

        class ProblemsModel
        {
            private int ProblemId;
            private string ProblemName;
            private ODS_db db;
            public ProblemsModel(int ProblemId = 0, string ProblemName = "")
            {
                this.ProblemId = ProblemId;
                this.ProblemName = ProblemName;
                db = new ODS_db();
            }

            public IEnumerable<ODS_Problems> GetProblems()
            {
                return db.ODS_Problems;
            }

            public bool Add()
            {
                ODS_Problems p = new ODS_Problems();
                p.Problem = this.ProblemName;
                try
                {
                    db.ODS_Problems.AddObject(p);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
            public bool Change()
            {
                var p = new ODS_Problems();
                try
                {
                    p = db.ODS_Problems.SingleOrDefault(ODS_Problems => ODS_Problems.ProblemId == this.ProblemId);
                    p.Problem = this.ProblemName;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
            public bool Delete()
            {
                var p = new ODS_Problems();
                try
                {
                    p = db.ODS_Problems.SingleOrDefault(ODS_Problems => ODS_Problems.ProblemId == this.ProblemId);
                    db.ODS_Problems.DeleteObject(p);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
        }

        class PowersModel
        {
            private int PowerId;
            private string PowerName;
            private ODS_db db;
            public PowersModel(int id = 0, string name = "")
            {
                this.PowerId = id;
                this.PowerName = name;
                db = new ODS_db();
            }

            public IEnumerable<ODS_Powers> GetPowers()
            {
                return db.ODS_Powers;
            }

            public bool Add()
            {
                ODS_Powers p = new ODS_Powers();
                p.Power = this.PowerName;
                try
                {
                    db.ODS_Powers.AddObject(p);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            public bool Change()
            {
                var p = new ODS_Powers();
                try
                {
                    p = db.ODS_Powers.SingleOrDefault(ODS_Powers => ODS_Powers.PowerId == this.PowerId);
                    p.Power = this.PowerName;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            public bool Delete()
            {
                var p = new ODS_Powers();
                try
                {
                    p = db.ODS_Powers.SingleOrDefault(ODS_Powers => ODS_Powers.PowerId == this.PowerId);
                    db.ODS_Powers.DeleteObject(p);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
        }

        class DamagesModel
        {
            private int DamageId;
            private string DamageName;
            private ODS_db db;
            public DamagesModel(int id = 0, string name = "")
            {
                this.DamageId = id;
                this.DamageName = name;
                db = new ODS_db();
            }

            public IEnumerable<ODS_Damages> GetDamages()
            {
                return db.ODS_Damages;
            }

            public bool Add()
            {
                ODS_Damages d = new ODS_Damages();
                d.Damage = this.DamageName;
                try
                {
                    db.ODS_Damages.AddObject(d);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
            public bool Change()
            {
                var d = new ODS_Damages();
                try
                {
                    d = db.ODS_Damages.SingleOrDefault(ODS_Damages => ODS_Damages.DamageId == this.DamageId);
                    d.Damage = this.DamageName;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
            public bool Delete()
            {
                try
                {
                    var d = db.ODS_Damages.SingleOrDefault(ODS_Damages => ODS_Damages.DamageId == this.DamageId);
                    db.ODS_Damages.DeleteObject(d);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
        }

        class AddressModel
        {
            private int AddressId;
            private int UchId;
            private string Address;
            private ODS_db db;
            public AddressModel(int AddressId = 0, int UchId = 0, string Address = "")
            {
                this.AddressId = AddressId;
                this.UchId = UchId;
                this.Address = Address;
                db = new ODS_db();
            }

            public IEnumerable<ODS_Address> GetAddresses()
            {
                return db.ODS_Address;
            }

            public bool Add()
            {
                try
                {
                    ODS_Address a = new ODS_Address();
                    a.UchId = this.UchId;
                    a.Address = this.Address;
                    db.ODS_Address.AddObject(a);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
            public bool Change()
            {
                var a = new ODS_Address();
                try
                {
                    a = db.ODS_Address.SingleOrDefault(ODS_Address => ODS_Address.AddressId == this.AddressId);
                    a.Address = this.Address;
                    a.UchId = this.UchId;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
            public bool Delete()
            {
                try
                {
                    var a = db.ODS_Address.SingleOrDefault(ODS_Address => ODS_Address.AddressId == this.AddressId);
                    db.ODS_Address.DeleteObject(a);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
        }

        class ClientsModel
        {
            protected int ClientId;
            protected string ClientFIO;
            protected string ClientPhone;
            protected int ClientHomeNum;
            protected int AddressId;
            protected string Liter;
            protected int Entrance;
            protected int Room;
            protected ODS_db db;
            public ClientsModel(int ClientId = 0, string ClientFIO = "", 
                string ClientPhone ="", int CHomeNum = 0, 
                int AddressId = 0, string Liter = "", 
                int Entrance = 0, int Room = 0)
            {
                this.db = new ODS_db();
                this.ClientId = ClientId;
                this.ClientFIO = ClientFIO;
                this.ClientPhone = ClientPhone;
                this.ClientHomeNum = CHomeNum;
                this.AddressId = AddressId;
                this.Liter = Liter;
                this.Entrance = Entrance;
                this.Room = Room;
            }

            public IEnumerable<ODS_Clients> GetClients()
            {
                return db.ODS_Clients;
            }

            public ODS_Clients GetClientById(int id)
            {
                return db.ODS_Clients.Single(ODS_Clients => ODS_Clients.ClientId == id);
            }

            public bool Add()
            {
                ODS_Clients c = new ODS_Clients();
                c.ClientFIO = this.ClientFIO;
                c.ClientPhone = this.ClientPhone;
                c.ClientHomeNum = this.ClientHomeNum;
                c.AddressId = this.AddressId;
                c.Liter = this.Liter;
                c.Entrance = this.Entrance;
                c.Room = this.Room;
                try
                {
                    db.ODS_Clients.AddObject(c);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool Change()
            {
                try
                {
                    var c = db.ODS_Clients.Single(ODS_Clients => ODS_Clients.ClientId == this.ClientId);
                    c.ClientFIO = this.ClientFIO;
                    c.ClientPhone = this.ClientPhone;
                    c.ClientPhone = this.ClientPhone;
                    c.ClientHomeNum = this.ClientHomeNum;
                    c.AddressId = this.AddressId;
                    c.Liter = this.Liter;
                    c.Entrance = this.Entrance;
                    c.Room = this.Room;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool Delete()
            {
                try
                {
                    var v = db.ODS_Clients.Single(ODS_Clients => ODS_Clients.ClientId == this.ClientId);
                    db.ODS_Clients.DeleteObject(v);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool ChangePhNum()
            {
                try
                {
                    ODS_Clients c = db.ODS_Clients.Single(ODS_Clients => ODS_Clients.ClientId == this.ClientId);
                    c.ClientPhone = this.ClientPhone;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
        }

        class JournalModel
        {
            public ODS_db db;
            public Guid JournalId;
            public int EntryID;
            public DateTime RecieveDate;
            public DateTime RecieveTime;
            public int ProblemId;
            public int ClientId;
            public int AddressId;
            public string PhNum;
            public int UserId;
            
            //для добавления записи
            public JournalModel(int ProblemId, int ClientId, string PhNum, int UserId, int AddressId)
            {
                this.JournalId = Guid.NewGuid();
                this.AddressId = AddressId;
                this.ProblemId = ProblemId;
                this.ClientId = ClientId;
                this.PhNum = PhNum;
                this.UserId = UserId;
                db = new ODS_db();
            }

            public JournalModel()
            {
                db = new ODS_db();
            }

            public IEnumerable<ODS_Journals> GetAllJEntries()
            {
                return db.ODS_Journals.OrderByDescending(ODS_Journals => ODS_Journals.RecieveDate).ThenByDescending(ODS_Journals => ODS_Journals.RecieveTime);
            }

            public void AddEntry()
            {
                ODS_Journals j = new ODS_Journals();
                j.JournalId = this.JournalId;
                j.EntryId = this.GetNewEntryNum();
                j.RecieveDate = DateTime.Now;
                j.RecieveTime = TimeSpan.Parse(DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString());
                j.AddressId = this.AddressId;
                j.ProblemId = this.ProblemId;
                j.ClientId = this.ClientId;
                j.ClientTelephone = this.PhNum;
                ClientsModel cm = new ClientsModel(this.ClientId, "", this.PhNum);
                cm.ChangePhNum();
                j.UserId = this.UserId;
                db.ODS_Journals.AddObject(j);
                db.SaveChanges();
            }

            public int GetNewEntryNum()
            {
                IEnumerable<ODS_Journals> jou = db.ODS_Journals.Where(ODS_Journals => ODS_Journals.RecieveDate.Year == DateTime.Now.Year);
                if (db.ODS_Journals.Count(ODS_Journals => ODS_Journals.RecieveDate.Year == DateTime.Now.Year) == 0)
                {
                    return 1;
                }
                else
                {
                    var max = jou.Max(ODS_Journals => ODS_Journals.EntryId);
                    return max+1;
                };
            }

            public bool SearchLast24HoursEntries(int AddressId)
            {
                DateTime dt = DateTime.Today.AddDays(-2);
                TimeSpan ts = new TimeSpan(DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second);
                var res = db.ODS_Journals.Where(
                    ODS_Journals => ODS_Journals.RecieveDate > dt
                    ).Where(
                    ODS_Journals => ODS_Journals.RecieveTime > ts || ODS_Journals.RecieveTime < ts
                    ).Where(
                    ODS_Journals => ODS_Journals.AddressId == AddressId
                    );
                if (res.Count()!=0)
                {
                    return true;
                }
                else
                {
                    return false;
                };
                return false;
            }

            public bool CloseEntry(Guid EntryId, string dateComplete, string timeComplete, int TPId, int DamageId, string comment, string MonterFIO, string MonterPh, int UserId)
            {
                try
                {
                    ODS_Journals entry = db.ODS_Journals.Single(ODS_Journals => ODS_Journals.JournalId == EntryId);
                    entry.DateComplete = DateTime.Parse(dateComplete);
                    entry.TimeComplete = TimeSpan.Parse(timeComplete);
                    entry.PowerId = TPId;
                    entry.DamageId = DamageId;
                    entry.Comment = comment;
                    UserModel m = new UserModel(UserId);
                    m.AddMonter(MonterFIO, MonterPh);
                    entry.ComplUserId = UserId;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public IEnumerable<ODS_Journals> GetEntryByIdEx(Guid JournalId)
            {
                return db.ODS_Journals.Where(ODS_Journals => ODS_Journals.JournalId == JournalId);
            }

            public ODS_Journals GetEntryById(Guid JournalId)
            {
                return db.ODS_Journals.Single(ODS_Journals => ODS_Journals.JournalId == JournalId);
            }
        }
    }
}