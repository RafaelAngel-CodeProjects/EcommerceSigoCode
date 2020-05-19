using System;
using System.Collections.Generic;
using Nop.Core.Plugins;
using Nop.Core;
using Nop.Services.Cms;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Payments.WalletCredit
{
    public class WalletCreditPlugin : BasePlugin, IWidgetPlugin
    {

        private readonly IWebHelper _webHelper;

        public WalletCreditPlugin(IWebHelper webHelper)
        {
            this._webHelper = webHelper;
        }
        /// <summary>
        /// Gets widget zones where this widget should be rendered
        /// </summary>
        /// <returns>Widget zones</returns>
        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.CheckoutPaymentInfoTop,
                                        AdminWidgetZones.CustomerDetailsInfoBottom };
        }

        /// <summary>
        /// Gets a configuration page URL
        /// </summary>
        public override string GetConfigurationPageUrl()
        {
            return _webHelper.GetStoreLocation() + "Admin/WidgetsWalletCredit/Configure";
        }

        /// <summary>
        /// Gets a name of a view component for displaying widget
        /// </summary>
        /// <param name="widgetZone">Name of the widget zone</param>
        /// <returns>View component name</returns>
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "WidgetWaletCredit";
        }

        public override void Install()
        {
            base.Install();
        }

        public override void Uninstall()
        {
            base.Uninstall();
        }

    }
}
