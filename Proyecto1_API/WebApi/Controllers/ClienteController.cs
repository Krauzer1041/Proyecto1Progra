using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/Cliente")]
    [ApiController]
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route(nameof(Consultar))]
        public IEnumerable<Cliente> Consultar()
        {
            return LogicaMongo.ConsultarCliente();
        }

        [HttpGet]
        [Route(nameof(ConsultarPorID))]
        public IEnumerable<Cliente> ConsultarPorID(Cliente P_entidad)
        {
            return LogicaMongo.ConsultarClienteID(P_entidad);
        }

        [HttpPost]
        [Route(nameof(Modificar))]
        public Resultado Modificar(Cliente P_Entidad)
        {
            return LogicaMongo.ModificarCliente(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(Eliminar))]
        public Resultado Eliminar(Cliente P_Entidad)
        {
            return LogicaMongo.EliminarCliente(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(Agregar))]
        public Resultado Agregar(Cliente P_Entidad)
        {
            return LogicaMongo.AgregarCliente(P_Entidad);
        }
    }
}
