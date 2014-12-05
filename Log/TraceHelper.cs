using System.Configuration;
using Freeway.Tracing;

namespace FRT.Portal.RedirectModule
{
    public static class TraceHelper
    {
        private const string STATIC_SOURCENAME = "DIY";
        private static readonly string StaticAppid = ConfigurationManager.AppSettings["AppID"];

        private static ITrace _tracer = null;

        /// <summary>
        /// 获取trace的静态实例
        /// </summary>
        public static ITrace Instance
        {
            get
            {
                if (_tracer != null)
                {
                    return _tracer;
                }

                string sourcename = string.IsNullOrEmpty(StaticAppid) ?
                STATIC_SOURCENAME :
                StaticAppid + STATIC_SOURCENAME;
                _tracer = TraceManager.GetTracer(sourcename);

                return _tracer;
            }
        }
    }
}
