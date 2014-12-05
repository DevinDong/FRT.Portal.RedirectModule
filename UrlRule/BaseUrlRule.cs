using System.Collections.Generic;
using System.Web;

namespace FRT.Portal.RedirectModule
{
    internal abstract class BaseUrlRule : ITransferable
    {
        /// <summary>
        /// 来源url模板
        /// </summary>
        public abstract List<string> SourceUrlPrefixs { get; }


        /// <summary>
        /// 跳转目的url模板
        /// </summary>
        public abstract string TargetUrlPrefix { get; }


        public abstract string Transfer(HttpRequest request);

    }
}
