using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Resultado
    {
        public string MensajeOperacion { get; set; }
        public bool OperacionSatisfactoria { get; set; }

        public Resultado()
        {
            MensajeOperacion = "Operacion realizada con exito";
            OperacionSatisfactoria = true;
        }
    }
}
