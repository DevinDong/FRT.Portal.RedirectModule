using System;
using Arch.CFramework.PlugIn.RegisterModule;

namespace FRT.Portal.RedirectModule
{

    public static class PreApplicationStartCode
    {
        private static bool _startWasCalled;

        public static void PreStart()
        {
            if (_startWasCalled) return;

            _startWasCalled = true;
            try
            {
                DynamicModuleUtility.RegisterModule(typeof(UrlRedirectModule));
            }
            catch (Exception ex)
            {
                LogHelper.Error("RedirectModuleStartup", ex);
            }
        }
    }
}
