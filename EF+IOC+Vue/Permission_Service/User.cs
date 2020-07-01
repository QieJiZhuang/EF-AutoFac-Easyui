using Permission_DTO;
using Permission_IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.SqlServer;

namespace Permission_Service
{
    public class User : IUser
    {
        public int AddUser(User_Info user_Info)
        {
            int result = 0;
            using (Permission db = new Permission())
            {
                User_Info user = db.User_Info.Add(user_Info);
                result = db.SaveChanges();
            }
            return result;
        }

        public int DeleteUser(string id)
        {
            using (Permission db = new Permission())
            {
                User_Info user_Info = db.User_Info.Where(m => m.ID == int.Parse(id)).FirstOrDefault();
                db.User_Info.Remove(user_Info);
                return db.SaveChanges();
            }
        }

        public bool exist(string name)
        {
            bool exist = false;
            using (Permission db = new Permission())
            {
                var user_Info = db.User_Info.Where(m => m.LoginName == name);
                if (user_Info.Count() > 0)
                {
                    exist = true;
                }
            }
            return exist;
        }

        public List<User_Info> GetInfo()
        {
            List<User_Info> list = null;
            using (Permission db = new Permission())
            {
                list = db.User_Info.ToList();
            }
            return list;
        }

        public string GetUserPwd(string user)
        {
            throw new NotImplementedException();
        }

        public User_Info GetUser_Info(string loginName)
        {
            User_Info user_Info = null;
            using (Permission db = new Permission())
            {
                user_Info = db.User_Info.Where(m => m.LoginName == loginName).FirstOrDefault();
            }
            return user_Info;
        }

        public int UpdataUser(User_Info user_Info)
        {
            using (var db = new Permission())
            {
                User_Info user = db.User_Info.Where(m => m.ID == user_Info.ID).FirstOrDefault();
                if (user != null)
                {
                    user.ID = user_Info.ID;
                    user.Creater = user_Info.Creater;
                    user.CreateTime = DateTime.Now;
                    user.Email = user_Info.Email;
                    user.IsDel = false;
                    user.LoginName = user_Info.LoginName;
                    user.Telephone = user.Telephone;
                    user.UserType = user.UserType;
                    return db.SaveChanges();
                }
                else
                {
                    return 0;
                }

            }
        }
    }
}
