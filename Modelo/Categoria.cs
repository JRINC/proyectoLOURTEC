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
    
    public partial class Categoria
    {
        public Categoria()
        {
            this.Categoria1 = new HashSet<Categoria>();
            this.Productoes = new HashSet<Producto>();
        }
    
        public int Id { get; set; }
        public int IdPadre { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Categoria> Categoria1 { get; set; }
        public virtual Categoria Categoria2 { get; set; }
        public virtual ICollection<Producto> Productoes { get; set; }
    }
}
