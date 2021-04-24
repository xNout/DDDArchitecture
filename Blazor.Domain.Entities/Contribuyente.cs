using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Domain.Entities
{
    public class Contribuyente
    {
        public string Tipo { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
    }
}
