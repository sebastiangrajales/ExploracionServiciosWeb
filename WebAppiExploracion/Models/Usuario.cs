using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppiExploracion.Models
{
    public class Usuario
    {
        public String id { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String rol { get; set; }
        public String nombreEquipo { get; set; }
    }
}