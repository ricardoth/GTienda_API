﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_TESIS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class bdEcommerceEntities : DbContext
    {
        public bdEcommerceEntities()
            : base("name=bdEcommerceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int pa_Activar_Categoria(Nullable<int> id_categoria)
        {
            var id_categoriaParameter = id_categoria.HasValue ?
                new ObjectParameter("id_categoria", id_categoria) :
                new ObjectParameter("id_categoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Activar_Categoria", id_categoriaParameter);
        }
    
        public virtual int pa_Activar_Cliente(Nullable<int> id_cliente)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Activar_Cliente", id_clienteParameter);
        }
    
        public virtual int pa_Activar_Ped_Prod(Nullable<int> id_ped_prod)
        {
            var id_ped_prodParameter = id_ped_prod.HasValue ?
                new ObjectParameter("id_ped_prod", id_ped_prod) :
                new ObjectParameter("id_ped_prod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Activar_Ped_Prod", id_ped_prodParameter);
        }
    
        public virtual int pa_Activar_Pedido(Nullable<int> id_pedido)
        {
            var id_pedidoParameter = id_pedido.HasValue ?
                new ObjectParameter("id_pedido", id_pedido) :
                new ObjectParameter("id_pedido", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Activar_Pedido", id_pedidoParameter);
        }
    
        public virtual int pa_Activar_Producto(Nullable<int> id_producto)
        {
            var id_productoParameter = id_producto.HasValue ?
                new ObjectParameter("id_producto", id_producto) :
                new ObjectParameter("id_producto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Activar_Producto", id_productoParameter);
        }
    
        public virtual int pa_Activar_Usuario(Nullable<int> id_usuario)
        {
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Activar_Usuario", id_usuarioParameter);
        }
    
        public virtual ObjectResult<string> pa_Combo_Categoria()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("pa_Combo_Categoria");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Combo_ID_Categoria()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Combo_ID_Categoria");
        }
    
        public virtual int pa_Eliminar_Categoria(Nullable<int> id_categoria)
        {
            var id_categoriaParameter = id_categoria.HasValue ?
                new ObjectParameter("id_categoria", id_categoria) :
                new ObjectParameter("id_categoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Eliminar_Categoria", id_categoriaParameter);
        }
    
        public virtual int pa_Eliminar_Cliente(Nullable<int> id_cliente)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Eliminar_Cliente", id_clienteParameter);
        }
    
        public virtual int pa_Eliminar_Ped_Prod(Nullable<int> id_ped_prod)
        {
            var id_ped_prodParameter = id_ped_prod.HasValue ?
                new ObjectParameter("id_ped_prod", id_ped_prod) :
                new ObjectParameter("id_ped_prod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Eliminar_Ped_Prod", id_ped_prodParameter);
        }
    
        public virtual int pa_Eliminar_Pedido(Nullable<int> id_pedido)
        {
            var id_pedidoParameter = id_pedido.HasValue ?
                new ObjectParameter("id_pedido", id_pedido) :
                new ObjectParameter("id_pedido", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Eliminar_Pedido", id_pedidoParameter);
        }
    
        public virtual int pa_Eliminar_Producto(Nullable<int> id_producto)
        {
            var id_productoParameter = id_producto.HasValue ?
                new ObjectParameter("id_producto", id_producto) :
                new ObjectParameter("id_producto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Eliminar_Producto", id_productoParameter);
        }
    
        public virtual int pa_Eliminar_Usuario(Nullable<int> id_usuario)
        {
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Eliminar_Usuario", id_usuarioParameter);
        }
    
        public virtual int pa_Insertar_Categoria(string nom_categoria, Nullable<bool> estado)
        {
            var nom_categoriaParameter = nom_categoria != null ?
                new ObjectParameter("nom_categoria", nom_categoria) :
                new ObjectParameter("nom_categoria", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Insertar_Categoria", nom_categoriaParameter, estadoParameter);
        }
    
        public virtual int pa_Insertar_Cliente(string nombre, string apellido, string rut, string direccion, string fono, Nullable<bool> estado)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var rutParameter = rut != null ?
                new ObjectParameter("rut", rut) :
                new ObjectParameter("rut", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var fonoParameter = fono != null ?
                new ObjectParameter("fono", fono) :
                new ObjectParameter("fono", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Insertar_Cliente", nombreParameter, apellidoParameter, rutParameter, direccionParameter, fonoParameter, estadoParameter);
        }
    
        public virtual int pa_Insertar_Ped_Prod(Nullable<int> producto, Nullable<int> pedido, Nullable<bool> estado)
        {
            var productoParameter = producto.HasValue ?
                new ObjectParameter("producto", producto) :
                new ObjectParameter("producto", typeof(int));
    
            var pedidoParameter = pedido.HasValue ?
                new ObjectParameter("pedido", pedido) :
                new ObjectParameter("pedido", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Insertar_Ped_Prod", productoParameter, pedidoParameter, estadoParameter);
        }
    
        public virtual int pa_Insertar_Pedido(string fecha, Nullable<int> monto, string detalle, Nullable<int> cliente, Nullable<int> producto, Nullable<bool> estado)
        {
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("monto", monto) :
                new ObjectParameter("monto", typeof(int));
    
            var detalleParameter = detalle != null ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(string));
    
            var clienteParameter = cliente.HasValue ?
                new ObjectParameter("cliente", cliente) :
                new ObjectParameter("cliente", typeof(int));
    
            var productoParameter = producto.HasValue ?
                new ObjectParameter("producto", producto) :
                new ObjectParameter("producto", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Insertar_Pedido", fechaParameter, montoParameter, detalleParameter, clienteParameter, productoParameter, estadoParameter);
        }
    
        public virtual int pa_Insertar_Producto(string nom_producto, string detalle, Nullable<bool> estado, Nullable<int> precio, Nullable<int> stock, Nullable<int> categoria)
        {
            var nom_productoParameter = nom_producto != null ?
                new ObjectParameter("nom_producto", nom_producto) :
                new ObjectParameter("nom_producto", typeof(string));
    
            var detalleParameter = detalle != null ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(bool));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(int));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("stock", stock) :
                new ObjectParameter("stock", typeof(int));
    
            var categoriaParameter = categoria.HasValue ?
                new ObjectParameter("categoria", categoria) :
                new ObjectParameter("categoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Insertar_Producto", nom_productoParameter, detalleParameter, estadoParameter, precioParameter, stockParameter, categoriaParameter);
        }
    
        public virtual int pa_Insertar_Usuario(string nom_usuario, string pass, Nullable<bool> estado)
        {
            var nom_usuarioParameter = nom_usuario != null ?
                new ObjectParameter("nom_usuario", nom_usuario) :
                new ObjectParameter("nom_usuario", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_Insertar_Usuario", nom_usuarioParameter, passParameter, estadoParameter);
        }
    
        public virtual ObjectResult<pa_Listar_Categoria_Result> pa_Listar_Categoria()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Categoria_Result>("pa_Listar_Categoria");
        }
    
        public virtual ObjectResult<pa_Listar_Categoria_ID_Result> pa_Listar_Categoria_ID(Nullable<int> id_categoria)
        {
            var id_categoriaParameter = id_categoria.HasValue ?
                new ObjectParameter("id_categoria", id_categoria) :
                new ObjectParameter("id_categoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Categoria_ID_Result>("pa_Listar_Categoria_ID", id_categoriaParameter);
        }
    
        public virtual ObjectResult<pa_Listar_Categoria_NoVigente_Result> pa_Listar_Categoria_NoVigente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Categoria_NoVigente_Result>("pa_Listar_Categoria_NoVigente");
        }
    
        public virtual ObjectResult<pa_Listar_Cliente_Result> pa_Listar_Cliente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Cliente_Result>("pa_Listar_Cliente");
        }
    
        public virtual ObjectResult<pa_Listar_Cliente_ID_Result> pa_Listar_Cliente_ID(Nullable<int> id_cliente)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Cliente_ID_Result>("pa_Listar_Cliente_ID", id_clienteParameter);
        }
    
        public virtual ObjectResult<pa_Listar_Cliente_NoVigente_Result> pa_Listar_Cliente_NoVigente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Cliente_NoVigente_Result>("pa_Listar_Cliente_NoVigente");
        }
    
        public virtual ObjectResult<pa_Listar_Ped_Prod_Result> pa_Listar_Ped_Prod()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Ped_Prod_Result>("pa_Listar_Ped_Prod");
        }
    
        public virtual ObjectResult<pa_Listar_Ped_Prod_ID_Result> pa_Listar_Ped_Prod_ID(Nullable<int> id_ped_prod)
        {
            var id_ped_prodParameter = id_ped_prod.HasValue ?
                new ObjectParameter("id_ped_prod", id_ped_prod) :
                new ObjectParameter("id_ped_prod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Ped_Prod_ID_Result>("pa_Listar_Ped_Prod_ID", id_ped_prodParameter);
        }
    
        public virtual ObjectResult<pa_Listar_Ped_Prod_NoVigente_Result> pa_Listar_Ped_Prod_NoVigente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Ped_Prod_NoVigente_Result>("pa_Listar_Ped_Prod_NoVigente");
        }
    
        public virtual ObjectResult<pa_Listar_Pedido_Result> pa_Listar_Pedido()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Pedido_Result>("pa_Listar_Pedido");
        }
    
        public virtual ObjectResult<pa_Listar_Pedido_ID_Result> pa_Listar_Pedido_ID(Nullable<int> id_pedido)
        {
            var id_pedidoParameter = id_pedido.HasValue ?
                new ObjectParameter("id_pedido", id_pedido) :
                new ObjectParameter("id_pedido", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Pedido_ID_Result>("pa_Listar_Pedido_ID", id_pedidoParameter);
        }
    
        public virtual ObjectResult<pa_Listar_Pedido_NoVigente_Result> pa_Listar_Pedido_NoVigente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Pedido_NoVigente_Result>("pa_Listar_Pedido_NoVigente");
        }
    
        public virtual ObjectResult<pa_Listar_Producto_Result> pa_Listar_Producto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Producto_Result>("pa_Listar_Producto");
        }
    
        public virtual ObjectResult<pa_Listar_Producto_ID_Result> pa_Listar_Producto_ID(Nullable<int> id_producto)
        {
            var id_productoParameter = id_producto.HasValue ?
                new ObjectParameter("id_producto", id_producto) :
                new ObjectParameter("id_producto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Producto_ID_Result>("pa_Listar_Producto_ID", id_productoParameter);
        }
    
        public virtual ObjectResult<pa_Listar_Producto_NoVigente_Result> pa_Listar_Producto_NoVigente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Producto_NoVigente_Result>("pa_Listar_Producto_NoVigente");
        }
    
        public virtual ObjectResult<pa_Listar_Usuario_Result> pa_Listar_Usuario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Usuario_Result>("pa_Listar_Usuario");
        }
    
        public virtual ObjectResult<pa_Listar_Usuario_ID_Result> pa_Listar_Usuario_ID(Nullable<int> id_usuario)
        {
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Usuario_ID_Result>("pa_Listar_Usuario_ID", id_usuarioParameter);
        }
    
        public virtual ObjectResult<pa_Listar_Usuario_NoVigente_Result> pa_Listar_Usuario_NoVigente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_Listar_Usuario_NoVigente_Result>("pa_Listar_Usuario_NoVigente");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Login(string nom_usuario, string pass)
        {
            var nom_usuarioParameter = nom_usuario != null ?
                new ObjectParameter("nom_usuario", nom_usuario) :
                new ObjectParameter("nom_usuario", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Login", nom_usuarioParameter, passParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Mayor_Pedido()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Mayor_Pedido");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Menor_Pedido()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Menor_Pedido");
        }
    
        public virtual ObjectResult<Nullable<decimal>> pa_Precio_IVA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("pa_Precio_IVA");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Precio_Maximo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Precio_Maximo");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Precio_Minimo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Precio_Minimo");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Precio_Promedio()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Precio_Promedio");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Suma_Monto_Pedidos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Suma_Monto_Pedidos");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Suma_Monto_Productos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Suma_Monto_Productos");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Suma_Stock()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Suma_Stock");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Total_Clientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Total_Clientes");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Total_Productos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Total_Productos");
        }
    
        public virtual ObjectResult<Nullable<int>> pa_Total_Usuarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_Total_Usuarios");
        }
    }
}
