using System.Web.Mvc;

namespace Sistema_Reserva_Alquiler_Habi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
