using Sistema_Reserva_Alquiler_Habi.Models;
using System.Web.Mvc;

namespace Sistema_Reserva_Alquiler_Habi.Controllers
{
    public class _NosotrosController : Controller
    {
        private ReservaAlquilerEntities db = new ReservaAlquilerEntities();

        // GET: _Nosotros
        public ActionResult Index()
        {
            return View();
        }


    }
}