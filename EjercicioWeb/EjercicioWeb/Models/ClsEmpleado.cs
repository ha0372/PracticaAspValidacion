using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioWeb.Models
{
    public class ClsEmpleado
    {
        private string nombreUsuario;
        private string duiU;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string DuiU { get => duiU; set => duiU = value; }

        //public string NombreUsuario { get; set; }
        //public string DuiU { get; set; }
    }
}