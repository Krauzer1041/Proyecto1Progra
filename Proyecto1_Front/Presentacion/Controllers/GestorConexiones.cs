using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Presentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class GestorConexiones : Controller
    {
        #region Propiedad

        public HttpClient Cliente { get; set; }

        #endregion

        #region Constructor 

        public GestorConexiones()
        {
            Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("http://localhost:27756");
            Cliente.DefaultRequestHeaders.Accept.Clear();
            Cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion

        #region Metodos
        #region Cliente
        public async Task<List<ClienteModel>> ListarCliente()
        {
            List<ClienteModel> lstresultados = new List<ClienteModel>();

            string url = "api/Cliente/Consultar";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var jsonSTRING = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<ClienteModel>>(jsonSTRING);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarCliente(ClienteModel P_Modelo)
        {
            string url = "api/Cliente/Agregar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarCliente(ClienteModel P_Modelo)
        {
            string url = "api/Cliente/Eliminar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarCliente(ClienteModel P_Modelo)
        {
            string url = "api/Cliente/Modificar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion
        #region Habitación
        public async Task<List<HabitacionModel>> ListarHabitacion()
        {
            List<HabitacionModel> lstresultados = new List<HabitacionModel>();

            string url = "api/Habitacion/Consultar";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var jsonSTRING = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<HabitacionModel>>(jsonSTRING);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarHabitacion(HabitacionModel P_Modelo)
        {
            string url = "api/Habitacion/Agregar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarHabitacion(HabitacionModel P_Modelo)
        {
            string url = "api/Habitacion/Eliminar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarHabitacion(HabitacionModel P_Modelo)
        {
            string url = "api/Habitacion/Modificar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion
        #region Reserva
        public async Task<List<ReservaModel>> ListarReserva()
        {
            List<ReservaModel> lstresultados = new List<ReservaModel>();

            string url = "api/Reserva/Consultar";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var jsonSTRING = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<ReservaModel>>(jsonSTRING);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarReserva(ReservaModel P_Modelo)
        {
            string url = "api/Reserva/Agregar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarReserva(ReservaModel P_Modelo)
        {
            string url = "api/Reserva/Eliminar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarReserva(ReservaModel P_Modelo)
        {
            string url = "api/Reserva/Modificar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion
        #endregion
    }
}
