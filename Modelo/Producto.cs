//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProveedorServicio.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public Producto()
        {
            this.Proveedors = new HashSet<Proveedor>();
        }
    
        public int Id { get; set; }
        public string UPC { get; set; }
        public string Nombre { get; set; }
        public string UnidadMedida { get; set; }
        public int IdCategoria { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Exento { get; set; }
        public decimal Existencia { get; set; }
        public bool Activo { get; set; }
        public bool TipoProducto { get; set; }
        public bool EsServicio { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
