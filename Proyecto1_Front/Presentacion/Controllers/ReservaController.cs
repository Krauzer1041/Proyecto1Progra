using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Presentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class ReservaController : Controller
    {
        public async Task<IActionResult> CrearReserva()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<HabitacionModel> lstHabitaciones = await objconexion.ListarHabitacion();
            List<ClienteModel> lstClientes = await objconexion.ListarCliente();

            for (int i = 0; i < lstHabitaciones.Count; i++) {
                if (lstHabitaciones[i].Condicion.Equals("Ocupada")) {
                    lstHabitaciones.RemoveAt(i); // Remover aquellas habitaciones ocupadas
                    i = -1;
                }                    
            }

            List<SelectListItem> habList = lstHabitaciones.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Codigo.ToString(),
                    Value = a.Codigo.ToString(),
                    Selected = false
                };
            });

            List<SelectListItem> clientList = lstClientes.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Cedula.ToString(),
                    Value = a.Cedula.ToString(),
                    Selected = false
                };
            });
            

            ViewBag.Clientes = clientList;
            ViewBag.Habitaciones = habList;
            return View();
        }

        public async Task<IActionResult> EditaReserva(int Id)
        {
            string id = ModelState.Values.Last().RawValue.ToString();

            GestorConexiones objconexion = new GestorConexiones();
            List<ReservaModel> lstresultados = await objconexion.ListarReserva();
            ReservaModel reserva = lstresultados.Find(x => x.ID.Equals(id));

            List<HabitacionModel> lstHabitaciones = await objconexion.ListarHabitacion();
            List<ClienteModel> lstClientes = await objconexion.ListarCliente();

            for (int i = 0; i < lstHabitaciones.Count; i++)
            {
                if (lstHabitaciones[i].Condicion.Equals("Ocupada"))
                {
                    if (!reserva.Habitacion.Codigo.Equals(lstHabitaciones[i].Codigo)) { 
                        lstHabitaciones.RemoveAt(i); // Remover aquellas habitaciones ocupadas
                        i = -1;
                    }
                }
            }

            List<SelectListItem> habList = lstHabitaciones.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Codigo.ToString(),
                    Value = a.Codigo.ToString(),
                    Selected = false
                };
            });

            List<SelectListItem> clientList = lstClientes.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Cedula.ToString(),
                    Value = a.Cedula.ToString(),
                    Selected = false
                };
            });


            ViewBag.Clientes = clientList;
            ViewBag.Habitaciones = habList;

            return View(reserva);
        }

        public async Task<IActionResult> Consultar()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<HabitacionModel> lstHabitaciones = await objconexion.ListarHabitacion();
            ViewBag.Habitaciones = lstHabitaciones;

            return View();
        }

        public async Task<IActionResult> Eliminar(int Id)
        {
            string id = ModelState.Values.Last().RawValue.ToString();

            GestorConexiones objconexion = new GestorConexiones();
            List<ReservaModel> lstresultados = await objconexion.ListarReserva();
            ReservaModel reserva = lstresultados.Find(x => x.ID.Equals(id));

            return View(reserva);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(ReservaModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();

            string CodHabitacion = Request.Form["Habitacion"].ToString();
            string CedCliente = Request.Form["Cliente"].ToString();

            List<HabitacionModel> lstHabitaciones = await objconexion.ListarHabitacion();
            HabitacionModel habitacion = lstHabitaciones.Find(x => x.Codigo.Equals(CodHabitacion));
            habitacion.Condicion = "Ocupada"; 
            await objconexion.ModificarHabitacion(habitacion);

            List<ClienteModel> lstClientes = await objconexion.ListarCliente();
            ClienteModel cliente = lstClientes.Find(x => x.Cedula.Equals(CedCliente));

            P_Modelo.Cliente = cliente;
            P_Modelo.Habitacion = habitacion;

            await objconexion.AgregarReserva(P_Modelo);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(ReservaModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();

            List<ReservaModel> lstresultados = await objconexion.ListarReserva();
            ReservaModel reserva = lstresultados.Find(x => x.ID.Equals(P_Modelo.ID));
            P_Modelo.Cliente = reserva.Cliente;
            P_Modelo.Habitacion = reserva.Habitacion;

            string CodHabitacion = Request.Form["Habitacion"].ToString();
            string CedCliente = Request.Form["Cliente"].ToString();

            if (!P_Modelo.Habitacion.Codigo.Equals(CodHabitacion)) {
                List<HabitacionModel> lstHabitaciones = await objconexion.ListarHabitacion();
                HabitacionModel antiguaHabitacion = lstHabitaciones.Find(x => x.Codigo.Equals(P_Modelo.Habitacion.Codigo));
                HabitacionModel nuevaHabitacion = lstHabitaciones.Find(x => x.Codigo.Equals(CodHabitacion));
                antiguaHabitacion.Condicion = "Disponible";
                nuevaHabitacion.Condicion = "Ocupada";
                P_Modelo.Habitacion = nuevaHabitacion;

                await objconexion.ModificarHabitacion(antiguaHabitacion);
                await objconexion.ModificarHabitacion(nuevaHabitacion);                
            }
            if (!P_Modelo.Cliente.Cedula.Equals(CedCliente))
            {
                List<ClienteModel> lstClientes = await objconexion.ListarCliente();
                ClienteModel cliente = lstClientes.Find(x => x.Cedula.Equals(CedCliente));

                P_Modelo.Cliente = cliente;
            }
            await objconexion.ModificarReserva(P_Modelo);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar(ReservaModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();

            List<ReservaModel> lstresultados = await objconexion.ListarReserva();
            ReservaModel reserva = lstresultados.Find(x => x.ID.Equals(P_Modelo.ID));

            List<HabitacionModel> lstHabitaciones = await objconexion.ListarHabitacion();
            HabitacionModel habitacion = lstHabitaciones.Find(x => x.Codigo.Equals(reserva.Habitacion.Codigo));

            habitacion.Condicion = "Disponible";

            await objconexion.ModificarHabitacion(habitacion);

            await objconexion.EliminarReserva(P_Modelo);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<ReservaModel> lstresultados = await objconexion.ListarReserva();

            return View(lstresultados);
        }
    }
}
