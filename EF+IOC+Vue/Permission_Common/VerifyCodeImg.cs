using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRS2018.Common
{
   public class VerifyCodeImg
    {
        public static string CreatImg(out string code)
        {
            VerifyCode.VerifyCodeImage verifycodeimage = new VerifyCode.VerifyCodeImage();
            string base64 = verifycodeimage.CreatVerifyImage(out code);
            return base64;
        }
    }
}
