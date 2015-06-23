using ProveedorServicio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProveedorServicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ProveedorServicio : IProveedorServicio
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        public bool InsertarProveedor(Modelo.Proveedor _proveedor)
        {
            try
            {
                using (var _context = new ProveedoresEntities())
                {
                    _context.Proveedors.Add(_proveedor);
                }
                return true;
            }
            catch (Exception ex)
            {
                // TODO Hacer algun tipo de LOG
                return false;
            }
        }

        public bool ActualizarProveedor(Modelo.Proveedor _proveedor)
        {
            throw new NotImplementedException();
        }

        public bool EliminarProveedor(Modelo.Proveedor _proveedor)
        {
            throw new NotImplementedException();
        }

        public List<Modelo.Proveedor> GetProveedores()
        {
            throw new NotImplementedException();
        }

        public Modelo.Proveedor GetProveedor(int _idProveedor)
        {
            throw new NotImplementedException();
        }

        public bool InsertarCategoria(Modelo.Categoria _categoria)
        {
            throw new NotImplementedException();
        }

        public bool ActualizarCategoria(Modelo.Categoria _categoria)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCategoria(Modelo.Categoria _categoria)
        {
            throw new NotImplementedException();
        }

        public List<Modelo.Categoria> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public Modelo.Categoria GetCategoria(int _idCategoria)
        {
            throw new NotImplementedException();
        }

        public bool InsertarProducto(Modelo.Producto _producto)
        {
            throw new NotImplementedException();
        }

        public bool ActualizarProducto(Modelo.Producto _producto)
        {
            throw new NotImplementedException();
        }

        public bool EliminarProducto(Modelo.Producto _producto)
        {
            throw new NotImplementedException();
        }

        public List<Modelo.Producto> GetProductos()
        {
            throw new NotImplementedException();
        }

        public Modelo.Producto GetProducto(int _idProducto)
        {
            throw new NotImplementedException();
        }
    }
}
