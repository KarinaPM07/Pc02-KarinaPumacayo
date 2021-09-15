using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Semana7PC02.Models
{
    public class Mascota{

        
        public int ID { get; set; }

        public string nombre { get; set; }

        public string apellidoPaterno { get; set; }

        public string apellidoMaterno { get; set; }

        public string tipo { get; set; }

        public string descripcion { get; set; }

        public int telefono { get; set; }

        public string distrito { get; set; }

        public string direccion { get; set; }

  
    }

}