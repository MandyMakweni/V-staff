using System.Web;
using System.Web.Mvc;

namespace OMStaffVolunteer2018
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
