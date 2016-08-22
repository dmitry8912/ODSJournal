using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Objects;
using ODSJournal.DataModel;
using System.Security.Cryptography;
using System.Windows.Forms;
using ODSJournal.Helpers;
namespace ODSJournal.DataModel
{
    namespace Model
    {
        //public static class GlobalModel
        //{
        //    public static int UserId;
        //    protected int RoleId;
        //    protected string Role;
        //    protected string UserFIO;
        //    public GlobalModel(ODS_Users user)
        //    {
        //        this.UserId = user.UserId;
        //        this.UserFIO = user.FIO;
        //        this.RoleId = user.RoleId;
        //        this.Role = this.GetUserRole();
        //    }
        //    protected string GetUserRole()
        //    {
        //        
        //        var role = db_ctx.db.ODS_Roles.Single(ODS_Roles => ODS_Roles.RoleId == this.RoleId);
        //        return role.Role;
        //    }

        //    public int GetUserId()
        //    {
        //        return this.UserId;
        //    }
        //    public int GetRoleId()
        //    {
        //        return this.RoleId;
        //    }
        //    public string GetUserFIO()
        //    {
        //        return this.UserFIO;
        //    }
        //    public string GetRole()
        //    {
        //        return this.Role;
        //    }
        //}
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
                    return true;
                }
                else
                {
                    return false;
                };
            }
        }
        public static class GlobalSettings
        {
            public static int FontSize { get; set; }
        }
        public static class db_ctx
        {
            public static ODS_db db { get; set; }
            public static void RefreshContext()
            {
                db = new ODS_db();
            }
        }
        public class RoleActionAssign
        {
            public readonly int[] AddrAddE = { 1, 11, };
            public readonly int[] AddrDel = { 1, /*5, 6, 7, 8, 9, 10, 11, 12, 13, 14*/ };

            public readonly int[] ClientAddE = { 1, 11, };
            public readonly int[] ClientDel = { 1, /*5, 6, 7, 8, 9, 10, 11, 12, 13, 14*/ };

            public readonly int[] DamageAddE = { 1, 11, };
            public readonly int[] DamageDel = { 1, /*5, 6, 7, 8, 9, 10, 11, 12, 13, 14*/ };

            public readonly int[] PowerAddE = { 1, 11, };
            public readonly int[] PowerDel = { 1, /*5, 6, 7, 8, 9, 10, 11, 12, 13, 14*/ };

            public readonly int[] ProblemAddE = { 1, 11, };
            public readonly int[] ProblemDel = { 1, /*5, 6, 7, 8, 9, 10, 11, 12, 13, 14*/ };

            public readonly int[] UchAddE = { 1, 11, };
            public readonly int[] UchDel = { 1, /*5, 6, 7, 8, 9, 10, 11, 12, 13, 14*/ };

            public readonly int[] JAdd = { 1, 11, 12 };
            public readonly int[] JEditClose = { 1, 9, 10, 11, 12, 13 };
            public readonly int[] JDel = { /*1, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14*/ };

            public readonly int[] UnloadInfo = { 1, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            public readonly int[] Print = { 1, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
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
            public UserModel(string UserName, string PlainPassword)
            {
                this.UserName = UserName;
                this.Password = this.GetHash(PlainPassword);
            }

            //Для добавления\изменения данных пользователя
            public UserModel(string UserName, string PlainPassword, string VName, int Role = 0)
            {
                this.UserName = UserName;
                this.Password = this.GetHash(PlainPassword);
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
                
                ODS_Users user = new ODS_Users();
                user.Login = this.UserName;
                user.Password = this.Password;
                user.FIO = this.ViewName;
                user.RoleId = this.RoleId;
                try
                {
                    db_ctx.db.ODS_Users.AddObject(user);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool ChangeUserPassword()
            {
                
                var user = new ODS_Users();
                try
                {
                    user = db_ctx.db.ODS_Users.SingleOrDefault(ODS_Users => ODS_Users.Login == this.UserName);
                    user.Password = this.Password;
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool ModifyUserData()
            {
                
                var user = new ODS_Users();
                try
                {
                    user = db_ctx.db.ODS_Users.SingleOrDefault(ODS_Users => ODS_Users.Login == this.UserName);
                    user.FIO = this.ViewName;
                    user.RoleId = this.RoleId;
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool DeleteUser()
            {
                
                var user = new ODS_Users();
                try
                {
                    user = db_ctx.db.ODS_Users.SingleOrDefault(ODS_Users => ODS_Users.Login == this.UserName);
                    db_ctx.db.ODS_Users.DeleteObject(user);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public bool AuthUser()
            {
                
                var user = new ODS_Users();
                string usern, pass;
                usern = this.UserName;
                pass = this.Password;
                try
                {
                    user = db_ctx.db.ODS_Users.Single(ODS_Users => ODS_Users.Login == usern && ODS_Users.Password == pass);
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
                
                var user = new ODS_Users();
                try
                {
                    user = db_ctx.db.ODS_Users.SingleOrDefault(ODS_Users => ODS_Users.UserId == this.UserId);
                    user.MonterFIO = MonterFIO;
                    user.MonterPhone = MonterPhone;
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }

            public ODS_Users GetUser()
            {
                
                try
                {
                    return db_ctx.db.ODS_Users.Single(ODS_Users => ODS_Users.Login == this.UserName && ODS_Users.Password == this.Password);
                }
                catch (Exception ex)
                {
                    return null;
                };
            }

            public ODS_Users GetUserById()
            {
                
                try
                {
                    return db_ctx.db.ODS_Users.Single(ODS_Users => ODS_Users.UserId == this.UserId);
                }
                catch (Exception ex)
                {
                    return null;
                };
            }

            public void GlobalUser()
            {
                
                var u = db_ctx.db.ODS_Users.Single(ODS_Users => ODS_Users.Login == this.UserName && ODS_Users.Password == this.Password);
                Global.UserId = u.UserId;
                Global.UserFIO = u.FIO;
                Global.RoleId = u.RoleId;
                Global.Role = u.ODS_Roles.Role;
            }

            public IEnumerable<ODS_Users> GetUsers()
            {
                
                return db_ctx.db.ODS_Users;
            }
        }
        class UchModel
        {
            private int UchId;
            private string UchName;
            public UchModel(int id = 0,string UchName= "")
            {
                this.UchId = id;
                this.UchName = UchName;
                
            }

            public IEnumerable<ODS_Uchs> GetUchs()
            {
                return db_ctx.db.ODS_Uchs.OrderBy(ODS_Uchs => ODS_Uchs.UchName);
            }

            public bool Add()
            {
                ODS_Uchs u = new ODS_Uchs();
                u.UchName = this.UchName;
                try
                {
                    db_ctx.db.ODS_Uchs.AddObject(u);
                    db_ctx.db.SaveChanges();
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
                    u = db_ctx.db.ODS_Uchs.SingleOrDefault(ODS_Uchs => ODS_Uchs.UchId == this.UchId);
                    u.UchName = this.UchName;
                    db_ctx.db.SaveChanges();
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
                    var u = db_ctx.db.ODS_Uchs.SingleOrDefault(ODS_Uchs => ODS_Uchs.UchId == this.UchId);
                    db_ctx.db.ODS_Uchs.DeleteObject(u);
                    db_ctx.db.SaveChanges();
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
            public ProblemsModel(int ProblemId = 0, string ProblemName = "")
            {
                this.ProblemId = ProblemId;
                this.ProblemName = ProblemName;
            }

            public IEnumerable<ODS_Problems> GetProblems()
            {
                return db_ctx.db.ODS_Problems.OrderBy(ODS_Problems => ODS_Problems.Problem);
            }

            public bool Add()
            {
                ODS_Problems p = new ODS_Problems();
                p.Problem = this.ProblemName;
                try
                {
                    db_ctx.db.ODS_Problems.AddObject(p);
                    db_ctx.db.SaveChanges();
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
                    p = db_ctx.db.ODS_Problems.SingleOrDefault(ODS_Problems => ODS_Problems.ProblemId == this.ProblemId);
                    p.Problem = this.ProblemName;
                    db_ctx.db.SaveChanges();
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
                    p = db_ctx.db.ODS_Problems.SingleOrDefault(ODS_Problems => ODS_Problems.ProblemId == this.ProblemId);
                    db_ctx.db.ODS_Problems.DeleteObject(p);
                    db_ctx.db.SaveChanges();
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
            private int FiderId;
            private string PowerName;
            
            public PowersModel(int id = 0, int fid = 0, string name = "")
            {
                this.PowerId = id;
                this.PowerName = name;
                this.FiderId = fid;
                
            }

            public IEnumerable<ODS_Powers> GetPowers()
            {
                return db_ctx.db.ODS_Powers.OrderBy(ODS_Powers => ODS_Powers.Power);
            }

            public ODS_Powers GetPowerById(int PowerId)
            {
                return db_ctx.db.ODS_Powers.Single(ODS_Powers => ODS_Powers.PowerId == PowerId);
            }

            public IEnumerable<ODS_Powers> GetPowerBySubUId(int UchId)
            {
                return db_ctx.db.ODS_Powers.Where(ODS_Powers => ODS_Powers.ODS_Fidres.ODS_Substations.UchId == UchId);
            }

            public bool Add()
            {
                ODS_Powers p = new ODS_Powers();
                p.Power = this.PowerName;
                p.FiderId = this.FiderId;
                try
                {
                    db_ctx.db.ODS_Powers.AddObject(p);
                    db_ctx.db.SaveChanges();
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
                    p = db_ctx.db.ODS_Powers.SingleOrDefault(ODS_Powers => ODS_Powers.PowerId == this.PowerId);
                    p.Power = this.PowerName;
                    p.FiderId = this.FiderId;
                    db_ctx.db.SaveChanges();
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
                    p = db_ctx.db.ODS_Powers.SingleOrDefault(ODS_Powers => ODS_Powers.PowerId == this.PowerId);
                    db_ctx.db.ODS_Powers.DeleteObject(p);
                    db_ctx.db.SaveChanges();
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
            
            public DamagesModel(int id = 0, string name = "")
            {
                this.DamageId = id;
                this.DamageName = name;
                
            }

            public IEnumerable<ODS_Damages> GetDamages()
            {
                return db_ctx.db.ODS_Damages.OrderBy(ODS_Damages => ODS_Damages.Damage);
            }

            public bool Add()
            {
                ODS_Damages d = new ODS_Damages();
                d.Damage = this.DamageName;
                try
                {
                    db_ctx.db.ODS_Damages.AddObject(d);
                    db_ctx.db.SaveChanges();
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
                    d = db_ctx.db.ODS_Damages.SingleOrDefault(ODS_Damages => ODS_Damages.DamageId == this.DamageId);
                    d.Damage = this.DamageName;
                    db_ctx.db.SaveChanges();
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
                    var d = db_ctx.db.ODS_Damages.SingleOrDefault(ODS_Damages => ODS_Damages.DamageId == this.DamageId);
                    db_ctx.db.ODS_Damages.DeleteObject(d);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                };
                return true;
            }
        }
        class ObjectModel
        {
            public int ObjectId;
            public string ObjectName;
            public ObjectModel(int id = 0, string name = "")
            {
                this.ObjectId = id;
                this.ObjectName = name;
            }

            public IEnumerable<ODS_Objects> GetObjects()
            {
                return db_ctx.db.ODS_Objects.OrderBy(ODS_Objects => ODS_Objects.Object);
            }

            public bool Add()
            {
                try
                {
                    ODS_Objects o = new ODS_Objects();
                    o.Object = this.ObjectName;
                    db_ctx.db.ODS_Objects.AddObject(o);
                    db_ctx.db.SaveChanges();
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
                    var a = db_ctx.db.ODS_Objects.Single(ODS_Objects => ODS_Objects.ObjectId == this.ObjectId);
                    a.Object = this.ObjectName;
                    db_ctx.db.SaveChanges();
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
                    var a = db_ctx.db.ODS_Objects.Single(ODS_Objects => ODS_Objects.ObjectId == this.ObjectId);
                    db_ctx.db.ODS_Objects.DeleteObject(a);
                    db_ctx.db.SaveChanges();
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
            public AddressModel(int AddressId = 0, int UchId = 0, string Address = "")
            {
                this.AddressId = AddressId;
                this.UchId = UchId;
                this.Address = Address;
                
            }

            public IEnumerable<ODS_Address> GetAddresses()
            {
                return db_ctx.db.ODS_Address.OrderBy(ODS_Address => ODS_Address.Address);
            }

            public IEnumerable<ODS_Address> GetAddressesByUID(int id)
            {
                return db_ctx.db.ODS_Address.Where(ODS_Address => ODS_Address.UchId == id).OrderBy(ODS_Address => ODS_Address.Address);
            }
            public bool Add()
            {
                try
                {
                    ODS_Address a = new ODS_Address();
                    a.UchId = this.UchId;
                    a.Address = this.Address;
                    db_ctx.db.ODS_Address.AddObject(a);
                    db_ctx.db.SaveChanges();
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
                    a = db_ctx.db.ODS_Address.SingleOrDefault(ODS_Address => ODS_Address.AddressId == this.AddressId);
                    a.Address = this.Address;
                    a.UchId = this.UchId;
                    db_ctx.db.SaveChanges();
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
                    var a = db_ctx.db.ODS_Address.SingleOrDefault(ODS_Address => ODS_Address.AddressId == this.AddressId);
                    db_ctx.db.ODS_Address.DeleteObject(a);
                    db_ctx.db.SaveChanges();
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
            
            public ClientsModel(int ClientId = 0, string ClientFIO = "", 
                string ClientPhone ="", int CHomeNum = 0, 
                int AddressId = 0, string Liter = "", 
                int Entrance = 0, int Room = 0)
            {
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
                return db_ctx.db.ODS_Clients;
            }

            public ODS_Clients GetClientById(int id)
            {
                return db_ctx.db.ODS_Clients.Single(ODS_Clients => ODS_Clients.ClientId == id);
            }

            public bool Add()
            {
                ODS_Clients c = new ODS_Clients();
                c.ClientFIO = this.ClientFIO;
                c.ClientPhone = this.ClientPhone;
                c.ClientHomeNum = this.ClientHomeNum;
                if (this.AddressId != 0)
                {
                    c.AddressId = this.AddressId;
                };
                c.Liter = this.Liter;
                c.Entrance = this.Entrance;
                c.Room = this.Room;
                try
                {
                    db_ctx.db.ODS_Clients.AddObject(c);
                    db_ctx.db.SaveChanges();
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
                    var c = db_ctx.db.ODS_Clients.Single(ODS_Clients => ODS_Clients.ClientId == this.ClientId);
                    c.ClientFIO = this.ClientFIO;
                    c.ClientPhone = this.ClientPhone;
                    c.ClientPhone = this.ClientPhone;
                    c.ClientHomeNum = this.ClientHomeNum;
                    c.AddressId = this.AddressId;
                    c.Liter = this.Liter;
                    c.Entrance = this.Entrance;
                    c.Room = this.Room;
                    db_ctx.db.SaveChanges();
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
                    var v = db_ctx.db.ODS_Clients.Single(ODS_Clients => ODS_Clients.ClientId == this.ClientId);
                    db_ctx.db.ODS_Clients.DeleteObject(v);
                    db_ctx.db.SaveChanges();
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
                    ODS_Clients c = db_ctx.db.ODS_Clients.Single(ODS_Clients => ODS_Clients.ClientId == this.ClientId);
                    c.ClientPhone = this.ClientPhone;
                    db_ctx.db.SaveChanges();
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
            public Guid JournalId;
            public int EntryID;
            public DateTime RecieveDate;
            public DateTime RecieveTime;
            public int ProblemId;
            //public int ClientId;
            public int AddressId;
            public int UserId;
            public int ObjectId;
            public string PhNum;
            public string HNum;
            public string ClientPlain;
            public string OpenComment;

            //для добавления записи
            public JournalModel(int AddressId, int ObjectId, string HNum, string ClientPlainName, 
                string PhNum, int ProblemId, int UserId, string OpenComment)
            {
                this.JournalId = Guid.NewGuid();
                this.AddressId = AddressId;
                this.ObjectId = ObjectId;
                this.HNum = HNum;
                this.ClientPlain = ClientPlainName;
                this.PhNum = PhNum;
                this.ProblemId = ProblemId;
                this.UserId = UserId;
                this.OpenComment = OpenComment;
                
            }

            public JournalModel()
            {
                
            }

            public IEnumerable<ODS_Journal> GetAllJEntries()
            {
                return db_ctx.db.ODS_Journal.Where(ODS_Journal => ODS_Journal.RecieveDate.Month == DateTime.Now.Month && ODS_Journal.RecieveDate.Year == DateTime.Now.Year).OrderByDescending(ODS_Journal => ODS_Journal.RecieveDate).ThenByDescending(ODS_Journal => ODS_Journal.RecieveTime);
            }

            public void AddEntry()
            {
                try
                {
                    ODS_Journal j = new ODS_Journal();
                    j.JournalId = this.JournalId;
                    j.EntryId = this.GetNewEntryNum();
                    j.RecieveDate = DateTime.Now;
                    j.RecieveTime = TimeSpan.Parse(DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString());
                    j.AddressId = this.AddressId;
                    j.ObjectId = this.ObjectId;
                    j.HNum = this.HNum;
                    j.ClientPlainName = this.ClientPlain;
                    j.ProblemId = this.ProblemId;
                    j.ClientTelephone = this.PhNum;
                    j.UserId = this.UserId;
                    j.OpenComment = this.OpenComment;
                    db_ctx.db.ODS_Journal.AddObject(j);

                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ADD PARAM</b></font><font color=\"black\">]</font> EID:["+j.EntryId.ToString()+ "] RT:[" 
                        + j.RecieveTime.ToString() + "]" + " AddressId:[" + j.AddressId.ToString() + "] ObjId:[" + j.ObjectId.ToString() + "]"
                        + " HNum:[" + j.HNum.ToString() + "] ClientName:[" + j.ClientPlainName.ToString() + "] ProblId:[" + j.ProblemId.ToString() + "]"
                        + " CT:[" + j.ClientTelephone.ToString() + "] OC:[" + j.OpenComment.ToString() + "] UserId:[" + j.UserId.ToString() + "]");

                    db_ctx.db.SaveChanges();

                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b align=\"center\">ADD END OK</b></font><font color=\"black\">]</font>");

                }
                catch (Exception ex)
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b>ADD ERROR</b></font><font color=\"black\">]</font> ExMess:["+ex.Message.ToString()+"] Inner:["+ex.InnerException.ToString()+"]");
                    return;
                };
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"red\"><b align=\"center\">ADD END NO ERR</b></font><font color=\"black\">]</font>");
            }

            public int GetNewEntryNum()
            {
                IEnumerable<ODS_Journal> jou = db_ctx.db.ODS_Journal.Where(ODS_Journal => ODS_Journal.RecieveDate.Year == DateTime.Now.Year);
                if (db_ctx.db.ODS_Journal.Count(ODS_Journal => ODS_Journal.RecieveDate.Year == DateTime.Now.Year) == 0)
                {
                    return 1;
                }
                else
                {
                    var max = jou.Max(ODS_Journal => ODS_Journal.EntryId);
                    return max+1;
                };
            }

            public bool SearchLast24HoursEntries(int AddressId)
            {
                int[] a = new int[6];
                DateTime dt = DateTime.Today.AddDays(-2);
                TimeSpan ts = new TimeSpan(DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second);
                var res = db_ctx.db.ODS_Journal.Where(
                    ODS_Journal => ODS_Journal.RecieveDate > dt
                    ).Where(
                    ODS_Journal => ODS_Journal.RecieveTime > ts || ODS_Journal.RecieveTime < ts
                    ).Where(
                    ODS_Journal => ODS_Journal.AddressId == AddressId
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

            public bool CloseEntry(Guid EntryId, string dateComplete, string timeComplete, int TPId, int DamageId, string comment, int MonterId, int UserId)
            {
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"blue\"><b align=\"center\">CLS PARAM</b></font><font color=\"black\">]</font>");
                try
                {
                    ODS_Journal entry = db_ctx.db.ODS_Journal.Single(ODS_Journal => ODS_Journal.JournalId == EntryId);
                    entry.DateComplete = DateTime.Parse(dateComplete);
                    entry.TimeComplete = TimeSpan.Parse(timeComplete);
                    entry.PowerId = TPId;
                    entry.DamageId = DamageId;
                    entry.Comment = comment;
                    entry.MonterId = MonterId;
                    entry.ComplUserId = UserId;
                    
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"blue\"><b>CLS</b></font><font color=\"black\">]</font> Entry Param: ID:[" + entry.JournalId.ToString() +"] EID:["+entry.EntryId.ToString() +"]"
                        +" DC:["+entry.DateComplete.Value.ToShortDateString()+"] TC:["+entry.TimeComplete.Value.ToString()+"] PowerId:["+entry.PowerId.ToString()+"]"
                        +" DamageId:["+entry.DamageId.ToString()+"] Comment:["+entry.Comment.ToString()+"] MonterId:["+entry.MonterId.ToString()+"]"
                        +" ComplUserId:["+entry.ComplUserId.ToString()+"]");

                    db_ctx.db.SaveChanges();

                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"blue\"><b align=\"center\">CLS END OK</b></font><font color=\"black\">]</font>");
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"blue\"><b>CLS ERR</b></font><font color=\"black\">]</font> ExMess:[" + ex.Message.ToString() + "] Inner:[" + ex.InnerException.ToString() + "]");
                    return false;
                };
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"blue\"><b align=\"center\">CLS END NO ERR</b></font><font color=\"black\">]</font>");
                return true;
            }

            public IEnumerable<ODS_Journal> GetEntryByIdEx(Guid JournalId)
            {
                return db_ctx.db.ODS_Journal.Where(ODS_Journal => ODS_Journal.JournalId == JournalId);
            }

            public ODS_Journal GetEntryById(Guid JournalId)
            {
                return db_ctx.db.ODS_Journal.Single(ODS_Journal => ODS_Journal.JournalId == JournalId);
            }

            public bool UpdateEntry(Guid Jid)
            {
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"blue\"><b align=\"center\">UPD PARAM</b></font><font color=\"black\">]</font>");
                try
                {
                    var entry = db_ctx.db.ODS_Journal.Single(ODS_Journal => ODS_Journal.JournalId == Jid);
                    entry.AddressId = this.AddressId;
                    entry.ProblemId = this.ProblemId;
                    entry.ObjectId = this.ObjectId;
                    entry.HNum = this.HNum;
                    entry.ClientPlainName = this.ClientPlain;
                    entry.ClientTelephone = this.PhNum;
                    entry.OpenComment = this.OpenComment;
                    

                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>UPD</b></font><font color=\"black\">]</font> Entry Param: ID:[" + entry.JournalId.ToString() + "] EID:["+entry.EntryId.ToString()+"] "
                        + " AddressId:[" + entry.AddressId.ToString() + "] ObjId:[" + entry.ObjectId.ToString() + "]"
                        + " HNum:[" + entry.HNum.ToString() + "] ClientName:[" + entry.ClientPlainName.ToString() + "] ProblId:[" + entry.ProblemId.ToString() + "]"
                        + " CT:[" + entry.ClientTelephone.ToString() + "] OC:[" + entry.OpenComment.ToString() + "]");

                    db_ctx.db.SaveChanges();

                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b align=\"center\">UPD END OK</b></font><font color=\"black\">]</font>");
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b>UPD ERR</b></font><font color=\"black\">]</font> ExMess:[" + ex.Message.ToString() + "] Inner:[" + ex.InnerException.ToString() + "]");
                    return false;
                };
                LogWriter.WriteLine("<font color=\"black\">[</font><font color=\"green\"><b align=\"center\">UPD END NO ERROR</b></font><font color=\"black\">]</font>");
                return true;
            }
        }
        class SubstationModel
        {
            protected int SId;
            protected string SName;
            protected int UId;
            
            public SubstationModel(int sid = 0, string name = "", int uid = 0)
            {
                this.SId = sid;
                this.SName = name;
                this.UId = uid;
            }

            public IEnumerable<ODS_Substations> GetStations()
            {
                return db_ctx.db.ODS_Substations.OrderBy(ODS_Substations => ODS_Substations.SubstationName);
            }

            public ODS_Substations GetStation(int id)
            {
                return db_ctx.db.ODS_Substations.Single(ODS_Substations => ODS_Substations.SubstationId == id);
            }

            public bool Add()
            {
                try
                {
                    ODS_Substations s = new ODS_Substations();
                    s.SubstationName = this.SName;
                    s.UchId = this.UId;
                    db_ctx.db.ODS_Substations.AddObject(s);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            public bool Change()
            {
                try
                {
                    var s = db_ctx.db.ODS_Substations.Single(ODS_Substations => ODS_Substations.SubstationId == this.SId);
                    s.SubstationName = this.SName;
                    s.UchId = this.UId;
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            public bool Delete()
            {
                try
                {
                    var s = db_ctx.db.ODS_Substations.Single(ODS_Substations => ODS_Substations.SubstationId == this.SId);
                    db_ctx.db.ODS_Substations.DeleteObject(s);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
        }
        class FiderModel
        {
            protected int FiderId;
            protected int SubstId;
            protected string Fider;
            
            public FiderModel(int FiderId = 0, int SubstId = 0, string Fider = "")
            {
                this.FiderId = FiderId;
                this.SubstId = SubstId;
                this.Fider = Fider;
            }

            public IEnumerable<ODS_Fidres> GetFiders()
            {
                return db_ctx.db.ODS_Fidres.OrderBy(ODS_Fidres => ODS_Fidres.FiderName);
            }

            public IEnumerable<ODS_Fidres> GetFidersBySId(int sid)
            {
                return db_ctx.db.ODS_Fidres.Where(ODS_Fidres => ODS_Fidres.SubstationId == sid).OrderBy(ODS_Fidres => ODS_Fidres.FiderName);
            }

            public bool Add()
            {
                try
                {
                    ODS_Fidres f = new ODS_Fidres();
                    f.SubstationId = this.SubstId;
                    f.FiderName = this.Fider;
                    db_ctx.db.ODS_Fidres.AddObject(f);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            public bool Change()
            {
                try
                {
                    var f = db_ctx.db.ODS_Fidres.Single(ODS_Fidres => ODS_Fidres.FiderId == this.FiderId);
                    f.SubstationId = this.SubstId;
                    f.FiderName = this.Fider;
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            public bool Delete()
            {
                try
                {
                    var f = db_ctx.db.ODS_Fidres.Single(ODS_Fidres => ODS_Fidres.FiderId == this.FiderId);
                    db_ctx.db.ODS_Fidres.DeleteObject(f);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
        }
        class MonterModel
        {
            protected int MonterId;
            protected string Monter;
            protected string MonterPhone;
            

            public MonterModel(int MonterId = 0, string Monter = "", string MonterPhone = "")
            {
                this.MonterId = MonterId;
                this.Monter = Monter;
                this.MonterPhone = MonterPhone;
            }

            public IEnumerable<ODS_Monters> GetMonters()
            {
                return db_ctx.db.ODS_Monters.OrderBy(ODS_Monters => ODS_Monters.MonerFIO);
            }

            public bool Add()
            {
                try
                {
                    ODS_Monters m = new ODS_Monters();
                    m.MonerFIO = this.Monter;
                    m.MonterPhone = this.MonterPhone;
                    db_ctx.db.ODS_Monters.AddObject(m);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            public bool Change()
            {
                try
                {
                    var m = db_ctx.db.ODS_Monters.Single(ODS_Monters => ODS_Monters.MonterId == this.MonterId);
                    m.MonerFIO = this.Monter;
                    m.MonterPhone = this.MonterPhone;
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            public bool Delete()
            {
                try
                {
                    var m = db_ctx.db.ODS_Monters.Single(ODS_Monters => ODS_Monters.MonterId == this.MonterId);
                    db_ctx.db.ODS_Monters.DeleteObject(m);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
        }
        class PrintModel
        {
            public Guid JournalId;
            public int UserId;
            
            public PrintModel(Guid JId, int UId)
            {
                this.JournalId = JId;
                this.UserId = UId;
            }
            public void AddPritInfo()
            {
                try
                {
                    ODS_PrintedEntries p = new ODS_PrintedEntries();
                    p.JournalId = this.JournalId;
                    p.UserId = this.UserId;
                    p.PrintDateTime = DateTime.Now;
                    db_ctx.db.ODS_PrintedEntries.AddObject(p);
                    db_ctx.db.SaveChanges();
                }
                catch (Exception ex)
                {

                };
            }
            public bool isPrinted()
            {
                try
                {
                    int c = db_ctx.db.ODS_PrintedEntries.Count(ODS_PrintedEntries => ODS_PrintedEntries.JournalId == this.JournalId);
                    if (c > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    };
                }
                catch (Exception ex)
                {
                    return false;
                };
            }
            public IEnumerable<ODS_PrintedEntries> GetJournalPrintInfo()
            {
                return db_ctx.db.ODS_PrintedEntries.Where(ODS_PrintedEntries => ODS_PrintedEntries.JournalId == this.JournalId);
            }
        }
    }
}
