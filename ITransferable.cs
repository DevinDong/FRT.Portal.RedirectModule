using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace FRT.Portal.RedirectModule
{
    internal interface ITransferable
    {
        /// <summary>
        /// 将sourceurl转换成targeturl
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        string Transfer(HttpRequest request);
    }
}
