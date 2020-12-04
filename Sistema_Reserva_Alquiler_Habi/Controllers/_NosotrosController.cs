using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_Reserva_Alquiler_Habi.Models;

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