using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        #region Propiedades

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ID { get; set; }

        [BsonElement("Cedula")]
        public string Cedula { get; set; }

        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        [BsonElement("Apellidos")]
        public string Apellidos { get; set; }

        [BsonElement("Correo")]
        public string Correo { get; set; }

        #endregion

        #region Constructor

        public Cliente()
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
