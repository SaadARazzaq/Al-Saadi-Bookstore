using System.Web;
using System.Web.Mvc;

namespace _20F_0292_BCS_6E_Advanced_Programming_Final
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
