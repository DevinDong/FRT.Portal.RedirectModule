using System;
using System.Collections.Generic;

namespace FRT.Portal.RedirectModule
{
    public class LogHelper
    {
        #region Debug
        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Debug(string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.DEBUG, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Debug(string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.DEBUG, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Debug(Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.DEBUG, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Debug(Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.DEBUG, exception, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Debug(string title, string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.DEBUG, title, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Debug(string title, string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.DEBUG, title, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Debug(string title, Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.DEBUG, title, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Debug(string title, Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.DEBUG, title, exception, addInfo);
        }
        #endregion

        #region Info
        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Info(string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.INFO, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Info(string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.INFO, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Info(Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.INFO, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Info(Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.INFO, exception, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Info(string title, string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.INFO, title, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Info(string title, string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.INFO, title, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Info(string title, Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.INFO, title, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Info(string title, Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.INFO, title, exception, addInfo);
        }
        #endregion

        #region Warn
        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Warn(string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.WARN, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Warn(string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.WARN, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Warn(Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.WARN, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Warn(Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.WARN, exception, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Warn(string title, string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.WARN, title, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Warn(string title, string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.WARN, title, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Warn(string title, Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.WARN, title, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Warn(string title, Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.WARN, title, exception, addInfo);
        }
        #endregion

        #region Error
        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Error(string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.ERROR, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Error(string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.ERROR, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Error(Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.ERROR, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Error(Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.ERROR, exception, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Error(string title, string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.ERROR, title, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Error(string title, string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.ERROR, title, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Error(string title, Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.ERROR, title, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Error(string title, Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.ERROR, title, exception, addInfo);
        }
        #endregion

        #region Fatal
        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Fatal(string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.FATAL, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Fatal(string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.FATAL, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Fatal(Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.FATAL, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="exception">异常信息</param>
        public static void Fatal(Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.FATAL, exception, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Fatal(string title, string message)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.FATAL, title, message);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="message">日志信息</param>
        public static void Fatal(string title, string message, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.FATAL, title, message, addInfo);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Fatal(string title, Exception exception)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.FATAL, title, exception);
        }

        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="title">日志标题</param>
        /// <param name="exception">异常信息</param>
        public static void Fatal(string title, Exception exception, Dictionary<string, string> addInfo)
        {
            TraceHelper.Instance.Log(Freeway.Gen.V2.LogType.APP, Freeway.Gen.V2.LogLevel.FATAL, title, exception, addInfo);
        }
        #endregion
    }
}
