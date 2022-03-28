using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Entidades
{
    public class Habitacion
    {
        #region Propiedades

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ID { get; set; }

        [BsonElement("Código")]
        public string Codigo { get; set; }

        [BsonElement("Tipo")]
        public string Tipo { get; set; }

        [BsonElement("Capacidad")]
        public int Capacidad { get; set; }

        [BsonElement("Condicion")]
        public string Condicion { get; set; }

        //[BsonElement("Condicion")]
        //public bool Condicion { get; set; }

        #endregion

        #region Constructor

        public Habitacion()
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
