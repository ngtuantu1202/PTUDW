using System.Web;
using System.Web.Mvc;

namespace ThiGKNguyenTuanTu_63135967
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
