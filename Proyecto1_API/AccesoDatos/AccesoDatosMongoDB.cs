using Entidades;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace AccesoDatos
{
    public class AccesoDatosMongoDB
    {
        #region Atributos

        //Se guarda la instancia a base de datos
        private readonly string Cadenaconexion = @"mongodb+srv://Jason:Krauzer1041@cluster0.qmyw5.mongodb.net/Hotel_Proyecto?retryWrites=true&w=majority";


        //Objetos para realizar la conexión 
        private MongoClient InstanciaMongoDB;
        private IMongoDatabase BaseDatos;

        //Nombre la base de datos 
        private const string NombreBD = "Hotel_Proyecto";

        #endregion

        #region Constructor

        public AccesoDatosMongoDB()
        {
            try
            {
                GetConexion();
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }
        }

        #endregion

        #region Metodos

        #region Privados 

        /// <summary>
        /// Metodo para probar conexion con MondoDB
        /// </summary>
        /// <returns></returns>
        private bool GetConexion()
        {
            bool ConexionCorrecta = false;

            try
            {
                //Inicializo el objeto de instancia Mongo
                InstanciaMongoDB = new MongoClient(Cadenaconexion);

                //Prueba conexion a BD
                BaseDatos = InstanciaMongoDB.GetDatabase(NombreBD);

                //Verifica conexion positiva
                ConexionCorrecta = BaseDatos.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ConexionCorrecta;
        }

        #endregion

        #region Publicos 
        #region Cliente
        /// <summary>
        /// Metodo para agregar un Cliente
        /// </summary>
        /// <param name="P_EntidadC">Entidad de tipo Cliente</param>
        /// <returns>True = Correcto | False = Error</returns>
        public bool AgregarCliente(Cliente P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Cliente>("Cliente");

                Coleccion.InsertOne(P_Entidad);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo para modificar un Cliente
        /// </summary>
        /// <param name="P_EntidadC">Entidad de tipo Cliente</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public bool ModificarCliente(Cliente P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Cliente>("Cliente");

                Coleccion.ReplaceOne(d => d.ID == P_Entidad.ID, P_Entidad);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo para eliminar un Cliente
        /// </summary>
        /// <param name="P_EntidadC">Entidad de tipo Cliente</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public bool EliminarCliente(Cliente P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Cliente>("Cliente");

                Coleccion.DeleteOne(d => d.ID == P_Entidad.ID);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo de consultar los registros de la coleccion
        /// </summary>
        /// <returns>Entidad Lista de tipo Cliente</returns>
        public List<Cliente> ConsultarCliente()
        {
            List<Cliente> V_Lista = new List<Cliente>();

            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Cliente>("Cliente");
                V_Lista = Coleccion.Find(d => true).ToList();
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return V_Lista;
        }

        /// <summary>
        /// Metodo de consultar los registros de la coleccion
        /// </summary>
        /// <param name="P_EntidadC">Entidad de tipo Cliente</param>
        /// <returns>Entidad Lista de tipo Cliente</returns>
        public List<Cliente> ConsultarClienteID(Cliente P_Entidad)
        {
            List<Cliente> V_Lista = new List<Cliente>();

            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Cliente>("Cliente");
                V_Lista = Coleccion.Find(d => d.ID == P_Entidad.ID).ToList();
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return V_Lista;
        }

        #endregion

        #region Habitacion
        /// <summary>
        /// Metodo para agregar una Habitacion
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Habitacion</param>
        /// <returns>True = Correcto | False = Error</returns>
        public bool AgregarHabitacion(Habitacion P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Habitacion>("Habitacion");

                Coleccion.InsertOne(P_Entidad);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo para modificar una Habitacion
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Habitacion</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public bool ModificarHabitacion(Habitacion P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Habitacion>("Habitacion");

                Coleccion.ReplaceOne(d => d.ID == P_Entidad.ID, P_Entidad);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo para eliminar un Habitacion
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Habitacion</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public bool EliminarHabitacion(Habitacion P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Habitacion>("Habitacion");

                Coleccion.DeleteOne(d => d.ID == P_Entidad.ID);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo de consultar los registros de la coleccion
        /// </summary>
        /// <returns>Entidad Lista de tipo Habitacion</returns>
        public List<Habitacion> ConsultarHabitacion()
        {
            List<Habitacion> V_Lista = new List<Habitacion>();

            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Habitacion>("Habitacion");
                V_Lista = Coleccion.Find(d => true).ToList();
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return V_Lista;
        }

        /// <summary>
        /// Metodo de consultar los registros de la coleccion
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Habitacion</param>
        /// <returns>Entidad Lista de tipo Habitacion</returns>
        public List<Habitacion> ConsultarHabitacionID(Habitacion P_Entidad)
        {
            List<Habitacion> V_Lista = new List<Habitacion>();

            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Habitacion>("Habitacion");
                V_Lista = Coleccion.Find(d => d.ID == P_Entidad.ID).ToList();
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return V_Lista;
        }

        #endregion

        #region Reserva
        /// <summary>
        /// Metodo para agregar una Reserva
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Reserva</param>
        /// <returns>True = Correcto | False = Error</returns>
        public bool AgregarReserva(Reserva P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Reserva>("Reserva");

                Coleccion.InsertOne(P_Entidad);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo para modificar una Reserva
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Reserva</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public bool ModificarReserva(Reserva P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Reserva>("Reserva");

                Coleccion.ReplaceOne(d => d.ID == P_Entidad.ID, P_Entidad);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo para eliminar una Reserva
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Reserva</param>
        /// <returns>TRUE = Correcto | FALSE = Error</returns>
        public bool EliminarReserva(Reserva P_Entidad)
        {
            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Reserva>("Reserva");

                Coleccion.DeleteOne(d => d.ID == P_Entidad.ID);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (BaseDatos != null)
                    BaseDatos = null;
            }

            return true;
        }

        /// <summary>
        /// Metodo de consultar los registros de la coleccion
        /// </summary>
        /// <returns>Entidad Lista de tipo Habitacion</returns>
        public List<Reserva> ConsultarReserva()
        {
            List<Reserva> V_Lista = new List<Reserva>();

            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Reserva>("Reserva");
                V_Lista = Coleccion.Find(d => true).ToList();
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return V_Lista;
        }

        /// <summary>
        /// Metodo de consultar los registros de la coleccion
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Reserva</param>
        /// <returns>Entidad Lista de tipo Reserva</returns>
        public List<Reserva> ConsultarReservaID(Reserva P_Entidad)
        {
            List<Reserva> V_Lista = new List<Reserva>();

            try
            {
                GetConexion();
                var Coleccion = BaseDatos.GetCollection<Reserva>("Reserva");
                V_Lista = Coleccion.Find(d => d.ID == P_Entidad.ID).ToList();
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return V_Lista;
        }

        #endregion
        #endregion

        #endregion
    }
}
