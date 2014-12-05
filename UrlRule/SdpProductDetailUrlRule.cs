using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace FRT.Portal.RedirectModule
{
    internal class SdpProductDetailUrlRule : BaseUrlRule
    {
        private const string DEPARTCITYID = "2";

        public override List<string> SourceUrlPrefixs
        {
            get
            {
                //freetravel/P1S1D1C1
                return new List<string>()
                {
                    @"/freetravel/p"
                };
            }
        }

        public override string TargetUrlPrefix
        {
            get
            {
                return string.Format("http://m.ctrip.com/webapp/diyfhxsdp/detail");//?salecityid={0}&departcityid={1}&productid={2}&from={3}";
            }
        }

        public override string Transfer(HttpRequest request)
        {
            var urlBuilder = new StringBuilder();

            urlBuilder.Append(TargetUrlPrefix);

            var tuple = GetValuesTuple(request.Url.AbsoluteUri);

            var productid = tuple.Item1;
            var salecityid = tuple.Item2;

            if (string.IsNullOrEmpty(productid) || string.IsNullOrEmpty(salecityid))
            {
                throw new ArgumentException("Request Url is illegal.");
            }

            var from = "";
            if (request.UrlReferrer != null)
            {
                from = request.UrlReferrer.AbsoluteUri + "";
            }

            urlBuilder.AppendFormat("?salecityid={0}", salecityid);
            urlBuilder.AppendFormat("&departcityid={0}", DEPARTCITYID);
            urlBuilder.AppendFormat("&productid={0}", productid);

            if (!string.IsNullOrEmpty(from))
            {
                urlBuilder.AppendFormat("&from=", from);
            }

            return urlBuilder.ToString();
        }

        /// <summary>
        /// 获取productid，salecityid
        /// </summary>
        /// <param name="rawUrl"></param>
        /// <returns></returns>
        public Tuple<string, string> GetValuesTuple(string rawUrl)
        {
            var input = rawUrl;//"http://taocan.ctrip.com/freetravel/p12s12";
            const string pattern = @"/freetravel/p(\d+)s(\d+)";

            var rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            var matches = rgx.Matches(input);

            if (matches.Count <= 0)
            {
                throw new ArgumentException("Request Url is not illegal.");
            }

            var collection = matches[0].Value.Split('/')[2].Split('s');

            string pid = collection[0].Replace("p", "");
            string sid = collection[1];

            return new Tuple<string, string>(pid, sid);
        }


    }
}
