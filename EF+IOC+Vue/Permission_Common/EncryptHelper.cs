using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRS2018.Common
{
   public static class EncryptHelper
    {

        
        public static string MD5(string str)
        {
            string cl = str;
            string pwd = "";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();//实例化一个md5对像
                                                                                             // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 

                pwd = pwd + s[i].ToString("x");

            }
            return pwd;
        }


        //随机数相关
        /// <summary>
        /// 获取指定长度的任意字符串
        /// </summary>
        /// <param name="strLtngth"></param>
        /// <returns></returns>
        public static string getRandomstr(int strLtngth)
        {
            Random rd1 = new Random(GetRandomSeed());
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < strLtngth; i++)
            {
                builder.Append(rd1.Next(0, 9));
            }
            return builder.ToString();
        }
        /// <summary>
        /// 使产生的随机数不相同
        /// </summary>
        /// <returns></returns>
        private static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }
}
