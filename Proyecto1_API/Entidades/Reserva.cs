using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Reserva
    {
        #region Propiedades

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ID { get; set; }

        [BsonElement("Código")]
        public string Codigo { get; set; }

        [BsonElement("Fecha de Entrada")]
        public string fechaEntrada { get; set; }

        [BsonElement("Fecha de Salida")]
        public string fechaSalida { get; set; }

        [BsonElement("Cantidad de Adultos")]
        public int cantAdultos { get; set; }

        [BsonElement("Cantidad de Niños")]
        public int cantNinos { get; set; }

        [BsonElement("Habitacion")]
        public Habitacion Habitacion { get; set; }

        [BsonElement("Cliente")]
        public Cliente Cliente { get; set; }

        #endregion

        #region Constructor

        public Reserva()
        {
            ID = string.Empty;
            Codigo = string.Empty;
            fechaEntrada = string.Empty;
            fechaSalida = string.Empty;
            cantAdultos = 0;
            cantNinos = 0;
            Habitacion = null;
            Cliente = null;
        }
        #endregion
    }
}
