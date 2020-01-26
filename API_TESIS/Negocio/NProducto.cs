using API_TESIS.Entidades;
using API_TESIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Negocio
{
    public class NProducto
    {
        bdEcommerceEntities _bdEcommerceEntities = new bdEcommerceEntities();

        //activar Producto
        public int ActivarProducto(int id_producto)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Activar_Producto(id_producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede activar");
            }

            return id_producto;
        }

        //método para obtener una lista de productos
        public List<Producto> GetListaProductosNoVigente()
        {
            List<Producto> lstProducto = new List<Producto>();
            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Producto_NoVigente();

                foreach (var varProducto in varRespConsulta)
                {
                    Producto _Producto = new Producto();
                    _Producto.id_producto = varProducto.id_producto;
                    _Producto.nom_prod = varProducto.nom_prod;
                    _Producto.detalle = varProducto.detalle;
                    _Producto.estado = varProducto.estado;
                    _Producto.precio = varProducto.precio;
                    _Producto.stock = varProducto.stock;
                    _Producto.categoria = varProducto.nom_categoria;

                    lstProducto.Add(_Producto);
                }
            }
            catch (Exception ex)
            {
                Producto producto = new Producto()
                {
                    
                };
            }
            return lstProducto;
        }

        //método para obtener una lista de productos
        public List<Producto> GetListaProductos()
        {
            List<Producto> lstProducto = new List<Producto>();
            //aqui validar con try catch
            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Producto();

                foreach (var varProducto in varRespConsulta)
                {
                    Producto _Producto = new Producto();
                    _Producto.id_producto = varProducto.id_producto;
                    _Producto.nom_prod = varProducto.nom_prod;
                    _Producto.detalle = varProducto.detalle;
                    _Producto.estado = varProducto.estado;
                    _Producto.precio = varProducto.precio;
                    _Producto.stock = varProducto.stock;
                    _Producto.categoria = varProducto.nom_categoria;

                    lstProducto.Add(_Producto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso" + ex);
            }
            return lstProducto;
        }

        //Listar producto por el id
        public List<Producto> GetProductoID(int id_producto)
        {
            List<Producto> lstProducto = new List<Producto>();

            try
            {
                var respId = _bdEcommerceEntities.pa_Listar_Producto_ID(id_producto);

                foreach (var pro in respId)
                {
                    Producto p = new Producto();
                    p.id_producto = pro.id_producto;
                    p.nom_prod = pro.nom_prod;
                    p.detalle = pro.detalle;
                    p.estado = pro.estado;
                    p.precio = pro.precio;
                    p.stock = pro.stock;
                    p.categoria = pro.nom_categoria;

                    lstProducto.Add(p);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }
            return lstProducto;
        }

        //Delete Producto por id
        public int DeleteProducto(int id_producto)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Eliminar_Producto(id_producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede eliminar");
            }

            return id_producto;
        }

        //Post Producto
        public Producto PostProducto(Producto p)
        {
            try
            {
                int varRespConsulta = _bdEcommerceEntities.pa_Insertar_Producto(p.nom_prod, p.detalle, p.estado, p.precio, p.stock, Convert.ToInt32(p.categoria));
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return p;
        }

        public List<int> GetComboIDCategoria()
        {
            List<int> lstComboID = new List<int>();
            try
            {
                var varQuery = _bdEcommerceEntities.pa_Combo_ID_Categoria();
                foreach (var res in varQuery)
                {
                    int datos = Convert.ToInt32(res);
                    lstComboID.Add(datos);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede eliminar");
            }
            return lstComboID;
        }


        public List<string> GetComboCategoria()
        {
            List<string> lstComboID = new List<string>();
            try
            {
                var varQuery = _bdEcommerceEntities.pa_Combo_Categoria();
                foreach (var res in varQuery)
                {
                    string datos = Convert.ToString(res);
                    lstComboID.Add(datos);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede eliminar");
            }
            return lstComboID;
        }

    }
}