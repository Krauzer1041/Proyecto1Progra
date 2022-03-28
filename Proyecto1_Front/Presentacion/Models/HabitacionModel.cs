using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class HabitacionModel
    {
        #region Propiedades
        public string ID { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public string Condicion { get; set; }

        //[BsonElement("Condicion")]
        //public bool Condicion { get; set; }

        #endregion

        #region Constructor

        public HabitacionModel()
        {
            ID = string.Empty;
            Codigo = string.Empty;
            Tipo = string.Empty;
            Capacidad = 0;
            Condicion = string.Empty;
            //Condicion = true;
        }
        #endregion
    }
}
