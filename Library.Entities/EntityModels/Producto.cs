using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Entities.EntityModels
{
    public partial class Producto
    {
        public Producto()
        {
            Carrito = new HashSet<Carrito>();
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? IdMarca { get; set; }
        public int? IdCategoria { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Marca IdMarcaNavigation { get; set; }
        public virtual ICollection<Carrito> Carrito { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
