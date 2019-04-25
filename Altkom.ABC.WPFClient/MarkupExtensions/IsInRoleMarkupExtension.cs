using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Altkom.ABC.WPFClient.MarkupExtensions
{
    public class IsInRoleMarkupExtension : MarkupExtension
    {
        public string Role { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Thread.CurrentPrincipal.IsInRole(Role);
        }
    }
}
