using System;

namespace FRT.Portal.RedirectModule
{
    internal static class UserAgentHelper
    {

        /// <summary>
        /// 根据useragent判断是否是移动设备
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        public static bool IsMobile(string userAgent)
        {
            return HasAnyPadKeyword(userAgent) || HasAnyMobileKeyword(userAgent);
        }

        /// <summary>
        /// 判断是否pad
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        private static Boolean HasAnyPadKeyword(String userAgent)
        {
            return userAgent.Contains("ipad") || userAgent.Contains("lepad_");
        }

        /// <summary>
        /// 检测pc客户端
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        public static Boolean HasAnyDesktopKeyword(String userAgent)
        {
            var ua = userAgent;
            return ua.Contains("wow64") ||
            ua.Contains(".net clr") ||
            ua.Contains("gtb7") ||
            ua.Contains("macintosh") ||
            ua.Contains("slcc1") ||
            ua.Contains("gtb6") ||
            ua.Contains("funwebproducts") ||
            ua.Contains("aol 9.") ||
            ua.Contains("iceweasel") ||
            ua.Contains("epiphany") ||
            ua.Contains("gtb8");
        }

        /// <summary>
        /// 检测手机客户端访问
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        private static Boolean HasAnyMobileKeyword(String userAgent)
        {
            var ua = userAgent;
            return (ua.Contains("midp") ||
            ua.Contains("mobile") ||
                // ua.Contains("android") ||
                // ua.Contains("samsung") ||
            ua.Contains("nokia") ||
            ua.Contains("up.browser") ||
            ua.Contains("phone") ||
            ua.Contains("opera mini") ||
            ua.Contains("opera mobi") ||
            ua.Contains("brew") ||
            ua.Contains("sonyericsson") ||
            ua.Contains("blackberry") ||
            ua.Contains("netfront") ||
            ua.Contains("uc browser") ||
            ua.Contains("symbian") ||
            ua.Contains("j2me") ||
            ua.Contains("wap2.") ||
            ua.Contains("up.link") ||
            ua.Contains("windows ce") ||
            ua.Contains("vodafone") ||
            ua.Contains("ucweb") ||
            ua.Contains("zte-") ||
            ua.Contains("docomo") ||
            ua.Contains("armv") ||
            ua.Contains("maemo") ||
            ua.Contains("palm") ||
            ua.Contains("bolt") ||
            ua.Contains("fennec") ||
            ua.Contains("wireless") ||
            ua.Contains("adr-") ||
            ua.Contains("htc") ||
            ua.Contains("nintendo") ||
            ua.Contains("zunewp7") ||
            ua.Contains("skyfire") ||
            ua.Contains("silk") ||
            ua.Contains("untrusted") ||
            ua.Contains("lgtelecom") ||
            ua.Contains(" gt-") ||
            ua.Contains(" arm;") ||
            ua.Contains("ventana") ||
            ua.Contains("iphone") ||
            ua.Contains("ipod") ||
            ua.Contains("itouch") ||
            (ua.Contains("mqqbrowser") && ua.Contains("adr")) ||
            (ua.Contains("firefox") && ua.Contains("android")) ||
            (ua.Contains("firefox") && ua.Contains("mobile")) ||
            ua.Contains("windowsphone") ||
            ua.Contains("windows phone") ||
            ua.Contains("iemobile") ||
            ua.Contains("wp7") ||
            ua.Contains("wp8") ||
            ua.Contains("android 2") ||
            ua.Contains("android 3") ||
            ua.Contains("android 4") ||
            ua.Contains("android/2") ||
            ua.Contains("android/3") ||
            ua.Contains("android/4")
            );
        }
    }

}
