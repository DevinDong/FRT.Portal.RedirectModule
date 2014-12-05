using System.Collections.Generic;
using System.Web;

namespace FRT.Portal.RedirectModule
{
    internal class IndexUrlRule : BaseUrlRule
    {
        public override List<string> SourceUrlPrefixs
        {
            get
            {
                return new List<string>() { "http://taocan.ctrip.com/fh", "http://taocan.ctrip.com" };
            }
        }

        public override string TargetUrlPrefix
        {
            get { return "http://m.ctrip.com/webapp/diyfhx/index.html"; }
        }

        public override string Transfer(HttpRequest request)
        {
            var rst = TargetUrlPrefix;
            string from = string.Empty;
            if (request.UrlReferrer != null)
            {
                from = request.UrlReferrer.AbsoluteUri + "";
            }
            if (!string.IsNullOrEmpty(from))
            {
                rst = string.Concat(rst, "?from=", from);
            }

            return rst;
        }
    }
}
