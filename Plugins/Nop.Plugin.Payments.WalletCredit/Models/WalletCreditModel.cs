using Nop.Web.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Payments.WalletCredit.Models
{
    public class WalletCreditModel
    {
        public int id { get; set; }

        [NopResourceDisplayName("Plugins.Payments.WaletCredit.CustomerName")]
        public string CustomerName { get; set; }
        public decimal AmountCredit { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
