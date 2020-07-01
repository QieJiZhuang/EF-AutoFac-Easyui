using System.Web;
using System.Web.Mvc;

namespace EF_IOC_Vue
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
