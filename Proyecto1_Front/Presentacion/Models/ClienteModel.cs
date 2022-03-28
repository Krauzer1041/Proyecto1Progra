using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class ClienteModel
    {
        #region Propiedades

        public string ID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }

        #endregion

        #region Constructor

        public ClienteModel()
        {
            ID = string.Empty;
            Cedula = string.Empty;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Correo = string.Empty;
        }
        #endregion
    }
}
