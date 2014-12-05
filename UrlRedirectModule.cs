using System;
using System.Web;

namespace FRT.Portal.RedirectModule
{
    public class UrlRedirectModule : IHttpModule
    {
        private const string LOG_TITLE = "UrlRedirectModule";

        public void Dispose()
        {

        }


        public void Init(HttpApplication context)
        {
            context.BeginRequest += ProcessRequest;
        }

        private void ProcessRequest(object sender, EventArgs args)
        {
            try
            {
                HttpApplication app = sender as HttpApplication;
                if (app == null || app.Context == null || app.Context.Request == null) return;

                var context = app.Context;
                var request = app.Context.Request;

                //确保userAgent非空
                var userAgent = request.UserAgent;
                if (string.IsNullOrEmpty(userAgent)) return;

                //判断是否是移动设备,如果是,出异常跳转到自由行首页
                if (UserAgentHelper.IsMobile(userAgent.ToLower()))
                {
                    var url = "http://m.ctrip.com/webapp/diyfhx/index.html";
                    //处理异常跳转到H5首页
                    try
                    {
                        var processor = UrlRuleParser.Parse(request.Url.PathAndQuery);

                        url = processor.Transfer(request);
                    }
                    catch (Exception e)
                    {
                        LogHelper.Error(LOG_TITLE, e);
                    }

                    if (url + "" != string.Empty)
                    {
                        context.Response.StatusCode = 302;
                        context.Response.RedirectLocation = url;
                        app.CompleteRequest();
                        return;
                    }
                }

            }
            catch (Exception e)
            {
                LogHelper.Error(LOG_TITLE, e);
            }

        }

    }
}
