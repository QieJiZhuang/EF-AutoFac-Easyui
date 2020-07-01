using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRS2018.Common
{
    /// <summary>
    /// Log4Net日志封装类
    /// </summary>
    public class LogHelper
    {
         static LogHelper() {
            log4net.Config.XmlConfigurator.Configure();
        }
        /// <summary>
        /// 信息标志
        /// </summary>
        private static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");

        /// <summary>
        /// 错误标志
        /// </summary>
        private static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");

        /// <summary>
        /// 调试标志
        /// </summary>
        private static readonly log4net.ILog logdebug = log4net.LogManager.GetLogger("logdebug");

        #region 简单记录
        /// <summary>
        /// Log4Net信息记录封装
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static void Info(string message)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(message);
            }
        }

        /// <summary>
        /// Log4Net错误记录封装
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static void Error(string message)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(message);
            }
        }

        /// <summary>
        /// Log4Net调试记录封装
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static void Debug(string message)
        {
            if (logdebug.IsErrorEnabled)
            {
                logdebug.Debug(message);
            }
        }
        #endregion


        #region 详细记录
        /// <summary>
        /// Log4Net错误记录封装
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static void Error(string message, Exception ex)
        {
            if (logerror.IsErrorEnabled)
            {
                string errorMsg = GetErrorMsg(ex);
                logerror.ErrorFormat("【附加信息】 : {0}\r\n{1}", new object[] { message, errorMsg });
            }
        }

        /// <summary>
        /// Log4Net调试记录封装
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static void Debug(string message, Exception ex)
        {
            if (logdebug.IsDebugEnabled)
            {
                string errorMsg = GetErrorMsg(ex);
                logdebug.DebugFormat("【附加信息】 : {0}\r\n{1}", new object[] { message, errorMsg });
            }
        }

        /// <summary>
        /// Log4Net错误记录封装
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static void Error( Exception ex)
        {
            if (logerror.IsErrorEnabled)
            {
                string errorMsg = GetErrorMsg(ex);
                logerror.Error(errorMsg);
            }
        }

        /// <summary>
        /// Log4Net调试记录封装
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static void Debug( Exception ex)
        {
            if (logdebug.IsDebugEnabled)
            {
                string errorMsg = GetErrorMsg(ex);
                logdebug.Debug(errorMsg);
            }
        }

        /// <summary>
        /// 获取错误信息
        /// </summary>
        /// <param name="ex">异常</param>
        /// <returns>错误信息</returns>
        private static string GetErrorMsg(Exception ex)
        {
            string errorMsg = string.Format("【异常类型】：{0} <br>【异常信息】：{1} <br>【堆栈调用】：{2}",
                new object[] { ex.GetType().Name, ex.Message, ex.StackTrace });
            return errorMsg;
        }

        #endregion
    }
}
