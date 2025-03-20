using System.Web;
using System.Web.Mvc;

namespace Leccion_ORadicales
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
