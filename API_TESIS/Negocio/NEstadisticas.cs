using API_TESIS.Entidades;
using API_TESIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Negocio
{
    public class NEstadisticas
    {
        bdEcommerceEntities _bdEcommerceEntities = new bdEcommerceEntities();

        //Suma precio
        public int GetSumaProductos()
        {
            var respTotal = _bdEcommerceEntities.pa_Suma_Monto_Productos();
            try
            {

                foreach (var res in respTotal)
                {
                    int sumaProducto = Convert.ToInt32(res);
                    return sumaProducto;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }

            return Convert.ToInt32(respTotal);
        }

        //Suma stock
        public int GetTotalStock()
        {
            var respTotal = _bdEcommerceEntities.pa_Suma_Stock();
            try
            {
                foreach (var res in respTotal)
                {
                    int totalStock = Convert.ToInt32(res);
                    return totalStock;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }

            return Convert.ToInt32(respTotal);
        }

        //Precio Max
        public int GetPrecioMaximo()
        {
            var respTotal = _bdEcommerceEntities.pa_Precio_Maximo();
            try
            {
                foreach (var res in respTotal)
                {
                    int iva = Convert.ToInt32(res);
                    return iva;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return Convert.ToInt32(respTotal);
        }

        //Precio iva
        public List<Producto> GetIvaIncluido()
        {
            List<Producto> lstPrecio = new List<Producto>();
            var respTotal = _bdEcommerceEntities.pa_Precio_IVA();
            try
            {
                foreach (var res in respTotal)
                {
                    Producto p = new Producto();
                    p.precio = Convert.ToInt32(res);
                    lstPrecio.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return lstPrecio;
        }

        //iva grafico
        public List<int> GetIVAGrafico()
        {
            List<int> lstIva = new List<int>();
            var resIva = _bdEcommerceEntities.pa_Precio_IVA();
            try
            {
                foreach (var res in resIva)
                {
                    int iva = Convert.ToInt32(res);
                    lstIva.Add(iva);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return lstIva;
        }

        //Total clientes
        public int GetTotalClientes()
        {
            var respCuenta = _bdEcommerceEntities.pa_Total_Clientes();
            try
            {
                foreach (var res in respCuenta)
                {
                    int tot = Convert.ToInt32(res);
                    return tot;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }

            return Convert.ToInt32(respCuenta);
        }

        //Total usuarios
        public int GetTotalUsuarios()
        {
            var respUsuario = _bdEcommerceEntities.pa_Total_Usuarios();
            try
            {
                foreach (var res in respUsuario)
                {
                    int tot = Convert.ToInt32(res);
                    return tot;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }

            return Convert.ToInt32(respUsuario);
        }


        //Suma monto pedidos
        public int GetMontoPedidos()
        {
            var resMonto = _bdEcommerceEntities.pa_Suma_Monto_Pedidos();
            try
            {
                foreach (var monto in resMonto)
                {
                    int m = Convert.ToInt32(monto);
                    return m;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return Convert.ToInt32(resMonto);
        }

        //Mayor pedido
        public int GetMayorPedido()
        {
            var resMax = _bdEcommerceEntities.pa_Mayor_Pedido();
            try
            {
                foreach (var max in resMax)
                {
                    int m = Convert.ToInt32(max);
                    return m;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }

            return Convert.ToInt32(resMax);
        }

        //Menor pedido
        public int GetMenorPedido()
        {
            var resMin = _bdEcommerceEntities.pa_Menor_Pedido();
            try
            {
                foreach (var max in resMin)
                {
                    int m = Convert.ToInt32(max);
                    return m;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }

            return Convert.ToInt32(resMin);
        }
    }
}