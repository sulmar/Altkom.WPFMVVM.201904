using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Altkom.ABC.WPFClient.MarkupExtensions
{
    public class VersionMarkupExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Assembly.GetEntryAssembly().GetName().Version;
        }
    }
}
