using System;
using System.Linq;


namespace FRT.Portal.RedirectModule
{
    internal static class UrlRuleParser
    {
        /// <summary>
        /// 根据sourceUrl解析成对应的Rule。
        /// </summary>
        /// <param name="sourceUrl"></param>
        /// <returns></returns>
        internal static ITransferable Parse(string sourceUrl)
        {
            if (string.IsNullOrEmpty(sourceUrl))
            {
                throw new ArgumentNullException("sourceUrl", "sourceUrl不能为空。");
            }

            sourceUrl = sourceUrl.ToLower();

            ITransferable rule = null;

            var index = new IndexUrlRule();
            var list = new SdpListUrlRule();
            var detail = new SdpProductDetailUrlRule();

            if (list.SourceUrlPrefixs.Any(x => sourceUrl.StartsWith(x)))
            {
                rule = list;
            }
            else if (detail.SourceUrlPrefixs.Any(x => sourceUrl.StartsWith(x)))
            {
                rule = detail;
            }
            else
            {
                rule = index;
            }

            return rule;
        }


    }
}
