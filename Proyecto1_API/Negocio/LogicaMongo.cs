using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Negocio
{
    public class LogicaMongo
    {
        #region metodos privados

        private static void GuardarLOG(Exception ex)
        {
            string V_ruta = @"D:\Log_Error_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            if (!File.Exists(V_ruta)) //Si no existe archivo de logs
                File.Create(V_ruta).Close();
            FileStream V_archivo = new FileStream(V_ruta, FileMode.Append, FileAccess.Write);
            StreamWriter V_escribir = new StreamWriter(V_archivo);

            V_escribir.WriteLine("**********************************************************");
            V_escribir.WriteLine("Fecha: " + DateTime.Now.ToShortDateString());
            V_escribir.WriteLine("Mensaje: " + ex.Message);
            if (ex.InnerException != null)
                V_escribir.WriteLine("InnerExcepcion: " + ex.InnerException.Message);
            if (ex.StackTrace != null)
                V_escribir.WriteLine("StackTrace: " + ex.StackTrace.ToString());
            V_escribir.Close();
        }

        #endregion

        #region metodos publicos
        #region Cliente

        /// <summary>
        /// Metodo para agregar un Cliente
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Cliente</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado AgregarCliente(Cliente P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Cliente> lstCliente = objacceso.ConsultarCliente();
                lstCliente = lstCliente.FindAll(x => x.Cedula.ToUpper().Equals(P_Entidad.Cedula.ToUpper()));

                //Valida si la consulta NO retorno resultados, procede con agregar el cliente
                if (lstCliente.Count == 0)
                {
                    //Aqui ejecuta la acción de agregar cliente
                    V_resultado.OperacionSatisfactoria = objacceso.AgregarCliente(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al guardar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información ya existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para modificar un Cliente
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Cliente</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado ModificarCliente(Cliente P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Cliente> lstCliente = objacceso.ConsultarClienteID(P_Entidad);

                //Valida si la consulta NO retorno resultados, procede con modificar 
                if (lstCliente.Count > 0)
                {
                    //Aqui ejecuta la acción de modificar
                    V_resultado.OperacionSatisfactoria = objacceso.ModificarCliente(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al modificar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información no existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para borrar un Cliente
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Cliente</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado EliminarCliente(Cliente P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Cliente> lstCliente = objacceso.ConsultarClienteID(P_Entidad);

                //Valida si la consulta NO retorno resultados, procede con eliminar 
                if (lstCliente.Count > 0)
                {
                    //Aqui ejecuta la acción de eliminar 
                    V_resultado.OperacionSatisfactoria = objacceso.EliminarCliente(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al eliminar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información no existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para listar Clientes registrados por Usuario
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Cliente</param>
        /// <returns>Entidad Lista de tipo automovil</returns>
        public static List<Cliente> ConsultarClienteID(Cliente P_Entidad)
        {
            List<Cliente> lstCliente = new List<Cliente>();

            try
            {
                AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();
                lstCliente = objacceso.ConsultarClienteID(P_Entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstCliente;
        }

        /// <summary>
        /// Metodo para listar clientes registrados
        /// </summary>        
        /// <returns>Entidad Lista de tipo Cliente</returns>
        public static List<Cliente> ConsultarCliente()
        {
            List<Cliente> lstCliente = new List<Cliente>();

            try
            {
                AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();
                lstCliente = objacceso.ConsultarCliente();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstCliente;
        }

        #endregion

        #region Reserva

        /// <summary>
        /// Metodo para agregar una Reserva
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Reserva</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado AgregarReserva(Reserva P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Reserva> lstReserva = objacceso.ConsultarReserva();
                lstReserva = lstReserva.FindAll(x => x.Codigo.ToUpper().Equals(P_Entidad.Codigo.ToUpper()));

                //Valida si la consulta NO retorno resultados, procede con agregar
                if (lstReserva.Count == 0)
                {
                    //Aqui ejecuta la acción
                    V_resultado.OperacionSatisfactoria = objacceso.AgregarReserva(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al guardar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información ya existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para modificar una Reserva
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Reserva</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado ModificarReserva(Reserva P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Reserva> lstReserva = objacceso.ConsultarReservaID(P_Entidad);

                //Valida si la consulta NO retorno resultados, procede con modificar 
                if (lstReserva.Count > 0)
                {
                    //Aqui ejecuta la acción de modificar
                    V_resultado.OperacionSatisfactoria = objacceso.ModificarReserva(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al modificar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información no existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para borrar una Reserva
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Reserva</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado EliminarReserva(Reserva P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Reserva> lstReserva = objacceso.ConsultarReservaID(P_Entidad);

                //Valida si la consulta NO retorno resultados, procede con eliminar 
                if (lstReserva.Count > 0)
                {
                    //Aqui ejecuta la acción de eliminar 
                    V_resultado.OperacionSatisfactoria = objacceso.EliminarReserva(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al eliminar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información no existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para listar Reservas registrados por Usuario
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Reserva</param>
        /// <returns>Entidad Lista de tipo automovil</returns>
        public static List<Reserva> ConsultarReservaID(Reserva P_Entidad)
        {
            List<Reserva> lstReserva = new List<Reserva>();

            try
            {
                AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();
                lstReserva = objacceso.ConsultarReservaID(P_Entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstReserva;
        }

        /// <summary>
        /// Metodo para listar reservas registrados
        /// </summary>        
        /// <returns>Entidad Lista de tipo Reserva</returns>
        public static List<Reserva> ConsultarReserva()
        {
            List<Reserva> lstReserva = new List<Reserva>();

            try
            {
                AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();
                lstReserva = objacceso.ConsultarReserva();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstReserva;
        }

        #endregion

        #region Habitacion

        /// <summary>
        /// Metodo para agregar una Habitacion
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Habitacion</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado AgregarHabitacion(Habitacion P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Habitacion> lstHabitacion = objacceso.ConsultarHabitacion();
                lstHabitacion = lstHabitacion.FindAll(x => x.Codigo.ToUpper().Equals(P_Entidad.Codigo.ToUpper()));

                //Valida si la consulta NO retorno resultados, procede con agregar
                if (lstHabitacion.Count == 0)
                {
                    //Aqui ejecuta la acción
                    V_resultado.OperacionSatisfactoria = objacceso.AgregarHabitacion(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al guardar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información ya existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para modificar una Habitacion
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Habitacion</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado ModificarHabitacion(Habitacion P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Habitacion> lstHabitacion = objacceso.ConsultarHabitacionID(P_Entidad);

                //Valida si la consulta NO retorno resultados, procede con modificar 
                if (lstHabitacion.Count > 0)
                {
                    //Aqui ejecuta la acción de modificar
                    V_resultado.OperacionSatisfactoria = objacceso.ModificarHabitacion(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al modificar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información no existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para borrar una Habitacion
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Habitacion</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public static Resultado EliminarHabitacion(Habitacion P_Entidad)
        {
            Resultado V_resultado = new Resultado();
            AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();

            try
            {
                List<Habitacion> lstHabitacion = objacceso.ConsultarHabitacionID(P_Entidad);

                //Valida si la consulta NO retorno resultados, procede con eliminar 
                if (lstHabitacion.Count > 0)
                {
                    //Aqui ejecuta la acción de eliminar 
                    V_resultado.OperacionSatisfactoria = objacceso.EliminarHabitacion(P_Entidad);
                    if (!V_resultado.OperacionSatisfactoria)
                        V_resultado.MensajeOperacion = "Error al eliminar la información";
                }
                else
                {
                    V_resultado.MensajeOperacion = "La información no existe en la base de datos";
                    V_resultado.OperacionSatisfactoria = false;
                }

            }
            catch (Exception ex)
            {
                GuardarLOG(ex);
                V_resultado.MensajeOperacion = "Ocurrio un error, comuniquese con el encargado del sistema";
                V_resultado.OperacionSatisfactoria = false;
            }

            return V_resultado;
        }

        /// <summary>
        /// Metodo para listar Habitaciones registrados por Usuario
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Habitacion</param>
        /// <returns>Entidad Lista de tipo automovil</returns>
        public static List<Habitacion> ConsultarHabitacionID(Habitacion P_Entidad)
        {
            List<Habitacion> lstHabitacion = new List<Habitacion>();

            try
            {
                AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();
                lstHabitacion = objacceso.ConsultarHabitacionID(P_Entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstHabitacion;
        }

        /// <summary>
        /// Metodo para listar habitaciones registrados
        /// </summary>        
        /// <returns>Entidad Lista de tipo Habitacion</returns>
        public static List<Habitacion> ConsultarHabitacion()
        {
            List<Habitacion> lstHabitacion = new List<Habitacion>();

            try
            {
                AccesoDatosMongoDB objacceso = new AccesoDatosMongoDB();
                lstHabitacion = objacceso.ConsultarHabitacion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstHabitacion;
        }

        #endregion
        #endregion

    }
}
