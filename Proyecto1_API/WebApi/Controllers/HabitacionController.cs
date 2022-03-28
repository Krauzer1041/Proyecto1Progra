using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/Habitacion")]
    [ApiController]
    public class HabitacionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route(nameof(Consultar))]
        public IEnumerable<Habitacion> Consultar()
        {
            return LogicaMongo.ConsultarHabitacion();
        }

        [HttpGet]
        [Route(nameof(ConsultarPorID))]
        public IEnumerable<Habitacion> ConsultarPorID(Habitacion P_entidad)
        {
            return LogicaMongo.ConsultarHabitacionID(P_entidad);
        }

        [HttpPost]
        [Route(nameof(Modificar))]
        public Resultado Modificar(Habitacion P_Entidad)
        {
            return LogicaMongo.ModificarHabitacion(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(Eliminar))]
        public Resultado Eliminar(Habitacion P_Entidad)
        {
            return LogicaMongo.EliminarHabitacion(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(Agregar))]
        public Resultado Agregar(Habitacion P_Entidad)
        {
            return LogicaMongo.AgregarHabitacion(P_Entidad);
        }
    }
}
