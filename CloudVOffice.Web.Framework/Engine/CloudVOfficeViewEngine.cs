using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Web.Framework.Engine
{
    public class MultiAssemblyViewLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            const string adminAssembly = "Accounts.Base";

            var adminViewsLocations = new[]
            {
            $"/Plugins/{adminAssembly}/Views/{{1}}/{{0}}.cshtml",
            $"/Plugins/{adminAssembly}/Views/{{0}}.cshtml"
        };

            viewLocations = adminViewsLocations.Concat(viewLocations);

            return viewLocations;
        }
    }
}
