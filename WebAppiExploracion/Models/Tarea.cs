using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppiExploracion.Models
{
    public class Tarea
    {
        public String id { get; set; }
        public String nombre { get; set; }
        public int minutosLiderEquipo { get; set; }
        public int minutosLiderPlaneacion { get; set; }
        public int minutosLiderSoporte { get; set; }
        public int minutosLiderCalidad { get; set; }
        public int minutosLiderDesarrollo { get; set; }
        public int minutosPlaneados { get; set; }
    }
}