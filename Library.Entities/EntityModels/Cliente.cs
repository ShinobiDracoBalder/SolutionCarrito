using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Entities.EntityModels
{
    public partial class Cliente
    {
        public Cliente()
        {
            Carrito = new HashSet<Carrito>();
            Venta = new HashSet<Venta>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool? Reestablecer { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Carrito> Carrito { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
