using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Entities.EntityModels
{
    public partial class Carrito
    {
        public int IdCarrito { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProducto { get; set; }
        public int? Cantidad { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
