using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/Reserva")]
    [ApiController]
    public class ReservaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route(nameof(Consultar))]
        public IEnumerable<Reserva> Consultar()
        {
            return LogicaMongo.ConsultarReserva();
        }

        [HttpGet]
        [Route(nameof(ConsultarPorID))]
        public IEnumerable<Reserva> ConsultarPorID(Reserva P_entidad)
        {
            return LogicaMongo.ConsultarReservaID(P_entidad);
        }

        [HttpPost]
        [Route(nameof(Modificar))]
        public Resultado Modificar(Reserva P_Entidad)
        {
            return LogicaMongo.ModificarReserva(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(Eliminar))]
        public Resultado Eliminar(Reserva P_Entidad)
        {
            return LogicaMongo.EliminarReserva(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(Agregar))]
        public Resultado Agregar(Reserva P_Entidad)
        {
            return LogicaMongo.AgregarReserva(P_Entidad);
        }
    }
}
