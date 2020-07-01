using Permission_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission_IService
{
    public interface IUser
    {
        List<User_Info> GetInfo();

        /// <summary>
        /// 是否存在这个用户名
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool exist(string name);

        /// <summary>
        /// 获取用户密码串进行对比
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string GetUserPwd(string user); 

        /// <summary>
        /// 根据登录名获取用户信息
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        User_Info GetUser_Info(string loginName);

        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="user_Info"></param>
        /// <returns></returns>
        int AddUser(User_Info user_Info);

        /// <summary>
        /// 修改一个用户
        /// </summary>
        /// <param name="user_Info"></param>
        /// <returns></returns>
        int UpdataUser(User_Info user_Info);

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="user_Info"></param>
        /// <returns></returns>
        int DeleteUser(string id    );
    }
}
