using Permission_IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.SqlServer;
using Newtonsoft.Json;
using Permission_DTO;
using CPRS2018.Common;

namespace EF_IOC_Vue.Controllers
{
    public class HomeController : Controller
    {

        readonly IUser user;
        public HomeController(IUser user)
        {
            this.user = user;
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            ViewBag.data = JsonConvert.SerializeObject(user.GetInfo());
            return View();
        }

        public ActionResult UserManages()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetInfo()
        {
            string json = JsonConvert.SerializeObject(user.GetInfo());
            return Json(user.GetInfo());
        }

        [HttpPost]
        public JsonResult LoginUser(string Name, string Pwd)
        {
            JsonResult json = new JsonResult();
            ResultModel resultModel = new ResultModel();
            User_Info result = user.GetUser_Info(Name);
            string pwd = EncryptHelper.MD5(Pwd);
            if (result != null)
            {
                if (result.PassWord == pwd)
                {
                    resultModel.Ret = 200;
                    Session["UserName"] = Name;

                    resultModel.Data = Json(result);
                }
            }
            else
            {

                resultModel.code = 500;
                resultModel.Msg = "登陆失败";
            }
            json.Data = resultModel;
            return json;
        }

        [HttpPost]
        public JsonResult UpdateUser(FormCollection collection)
        {
            ResultModel resultModel = new ResultModel();
            User_Info user_Info = new User_Info();
            //user_Info.Creater = Session["UserName"].ToString();
            user_Info.Email = collection.Get("Email");
            user_Info.ID =int.Parse(collection.Get("ID"));
            user_Info.UserType =int.Parse(collection.Get("UserType"));
            user_Info.LoginName =collection.Get("LoginName");
            int result = user.UpdataUser(user_Info);
            if (result>0)
            {
                resultModel.Ret = 200;
                resultModel.data = result;
            }
            else
            {
                resultModel.Ret = 500;
                resultModel.Msg = "添加失败！";
                
            }
            return Json(resultModel);
        }


        [HttpPost]
        public JsonResult AddUser(string Name,string Email,string UserType,string Telephone,string pwd)
        {
            ResultModel resultModel = new ResultModel();
            User_Info user_Info = new User_Info();
            user_Info.LoginName = Name;
            user_Info.Email = Email;
            user_Info.UserType =int.Parse(UserType);
            user_Info.Telephone = Telephone;
            user_Info.PassWord = EncryptHelper.MD5(pwd);
            user_Info.CreateTime = DateTime.Now;
            user_Info.IsDel = true;
            int result = user.AddUser(user_Info);
            if (result > 0)
            {
                resultModel.Ret = 200;
                resultModel.data = result;
            }
            else
            {
                resultModel.Ret = 500;
                resultModel.Msg = "添加失败！";

            }
            var aa = Json(resultModel);
            return Json(resultModel);
        }

    }
}