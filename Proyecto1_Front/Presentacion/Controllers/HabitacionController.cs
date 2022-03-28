using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class HabitacionController : Controller
    {
        public IActionResult CrearHabitacion()
        {
            return View();
        }

        public async Task<IActionResult> EditaHabitacion(int Id)
        {
            string id = ModelState.Values.Last().RawValue.ToString();

            GestorConexiones objconexion = new GestorConexiones();
            List<HabitacionModel> lstresultados = await objconexion.ListarHabitacion();
            HabitacionModel habitacion = lstresultados.Find(x => x.ID.Equals(id));

            return View(habitacion);
        }

        public async Task<IActionResult> Eliminar(int Id)
        {
            string id = ModelState.Values.Last().RawValue.ToString();

            GestorConexiones objconexion = new GestorConexiones();
            List<HabitacionModel> lstresultados = await objconexion.ListarHabitacion();
            HabitacionModel habitacion = lstresultados.Find(x => x.ID.Equals(id));

            return View(habitacion);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(HabitacionModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.AgregarHabitacion(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(HabitacionModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.ModificarHabitacion(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar(HabitacionModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarHabitacion(P_Modelo);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<HabitacionModel> lstresultados = await objconexion.ListarHabitacion();

            return View(lstresultados);
        }
    }
}
