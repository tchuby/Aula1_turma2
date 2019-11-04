using System.Web;
using System.Web.Mvc;

namespace _10_31_Ex2_WebApi_InnerJoin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
