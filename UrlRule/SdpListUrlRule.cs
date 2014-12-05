using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace FRT.Portal.RedirectModule
{
    internal class SdpListUrlRule : BaseUrlRule
    {

        public override System.Collections.Generic.List<string> SourceUrlPrefixs
        {
            get
            {
                return new List<string>() 
                {
                    "/freetravel/search/?keywords", 
                    "/freetravel/d-" 
                };
            }
        }

        private const string SID = "2";

        public override string TargetUrlPrefix
        {
            get
            {
                return "http://m.ctrip.com/webapp/diyfhxsdp/list?";//sid={0}&aid={1}&aname={2}&from={3}
            }
        }

        public override string Transfer(HttpRequest request)
        {
            //到达城市id
            var aid = string.Empty;

            //到达城市name或者搜索keyword
            var aname = string.Empty;

            //售卖城市id
            var sid = SID;

            //来源
            var from = string.Empty;

            if (request.UrlReferrer != null)
            {
                from = request.UrlReferrer.AbsoluteUri + "";
            }

            //build url
            var urlBuilder = new StringBuilder();

            urlBuilder.Append(TargetUrlPrefix);

            var values = GetValuesTuple(request);

            urlBuilder.AppendFormat("sid={0}", sid);

            aid = values.Item1;
            if (!string.IsNullOrEmpty(aid)) urlBuilder.AppendFormat("&aid={0}", aid);

            aname = values.Item2;
            if (!string.IsNullOrEmpty(aname)) urlBuilder.AppendFormat("&anm={0}", HttpUtility.UrlEncode(HttpUtility.UrlDecode(aname)));

            if (!string.IsNullOrEmpty(from)) urlBuilder.AppendFormat("&from={0}", from);

            return urlBuilder.ToString();
        }

        /// <summary>
        /// 获取aid,aname。
        /// </summary>
        /// <param name="rawUrl"></param>
        /// <returns></returns>
        private Tuple<string, string> GetValuesTuple(HttpRequest request)
        {
            var rawUrl = request.Url.AbsoluteUri;
            var pathAndQuery = request.Url.PathAndQuery;

            //keywords
            if (pathAndQuery.StartsWith(SourceUrlPrefixs[0]))
            {
                return GetKeywordsTuple(rawUrl);
            }
            else if (pathAndQuery.StartsWith(SourceUrlPrefixs[1]))
            {
                return GetTupleWithoutKeywords(rawUrl);
            }
            else
            {
                throw new ArgumentException("Request Url is not illegle.");
            }
        }

        /// <summary>
        /// 获取关键字信息。
        /// </summary>
        /// <param name="rawUrl"></param>
        /// <returns></returns>
        private Tuple<string, string> GetKeywordsTuple(string rawUrl)
        {
            var input = rawUrl;//"http://taocan.ctrip.com/freetravel/d-sanya-61/";
            const string pattern = @"/freetravel/search/\?keywords=([%|A-Z|a-z|\d]*)";

            var rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            var matches = rgx.Matches(input);

            if (matches.Count <= 0)
            {
                throw new ArgumentException("Request Url is not illegal.");
            }

            var allvalue = matches[0].Value;

            var idname = allvalue.Split('/')[3].Split('=');

            string aid = string.Empty;
            string aname = idname[1];

            var rst = new Tuple<string, string>(aid, aname);
            return rst;
        }

        /// <summary>
        /// 获取非关键字元组信息。
        /// </summary>
        /// <param name="rawUrl"></param>
        /// <returns></returns>
        private Tuple<string, string> GetTupleWithoutKeywords(string rawUrl)
        {
            var input = rawUrl;//"http://taocan.ctrip.com/freetravel/d-sanya-61/";
            const string pattern = @"/freetravel/d-(\w+)-(\d+)";

            var rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            var matches = rgx.Matches(input);

            if (matches.Count <= 0)
            {
                throw new ArgumentException("Request Url is not illegal.");
            }

            var allvalue = matches[0].Value;

            var idname = allvalue.Split('/')[2].Split('-');

            string aname = HttpUtility.UrlDecode(idname[1]);
            string aid = idname[2];

            var rst = new Tuple<string, string>(aid, aname);
            return rst;
        }

    }
}
