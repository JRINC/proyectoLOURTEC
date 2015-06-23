using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProveedorServicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProveedorServicio
    {
        #region Proveedor
        [OperationContract]
        bool InsertarProveedor(Modelo.Proveedor _proveedor);

        [OperationContract]
        bool ActualizarProveedor(Modelo.Proveedor _proveedor);
        
        [OperationContract]
        bool EliminarProveedor(Modelo.Proveedor _proveedor);
        
        [OperationContract]
        List<Modelo.Proveedor> GetProveedores();
        
        [OperationContract]
        Modelo.Proveedor GetProveedor(int _idProveedor);
        #endregion

        #region Categoria
        [OperationContract]
        bool InsertarCategoria(Modelo.Categoria _categoria);
        
        [OperationContract]
        bool ActualizarCategoria(Modelo.Categoria _categoria);
        
        [OperationContract]
        bool EliminarCategoria(Modelo.Categoria _categoria);
        
        [OperationContract]
        List<Modelo.Categoria> GetCategorias();
        
        [OperationContract]
        Modelo.Categoria GetCategoria(int _idCategoria);
        #endregion

        #region Producto
        [OperationContract]
        bool InsertarProducto(Modelo.Producto _producto);
        
        [OperationContract]
        bool ActualizarProducto(Modelo.Producto _producto);
        
        [OperationContract]
        bool EliminarProducto(Modelo.Producto _producto);
        
        [OperationContract]
        List<Modelo.Producto> GetProductos();
        
        [OperationContract]
        Modelo.Producto GetProducto(int _idProducto);
        #endregion

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
