using System.Web;
using System.Web.Mvc;

namespace NvhK22cntt3Lession11_2210900031
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
