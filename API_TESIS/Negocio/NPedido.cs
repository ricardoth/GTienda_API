using API_TESIS.Entidades;
using API_TESIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Negocio
{
    public class NPedido
    {
        bdEcommerceEntities _bdEcommerceEntities = new bdEcommerceEntities();

        //activar pedido
        public int ActivarPedido(int id_pedido)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Activar_Pedido(id_pedido);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede Activar");
            }

            return id_pedido;
        }

        //delete pedido
        public int DeletePedido(int id_pedido)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Eliminar_Pedido(id_pedido);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede eliminar");
            }

            return id_pedido;
        }
        //Listar Pedido por id
        public List<Pedido> GetPedidoID(int id_pedido)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            try
            {
                var respId = _bdEcommerceEntities.pa_Listar_Pedido_ID(id_pedido);
                foreach (var ped in respId)
                {
                    Pedido p = new Pedido();
                    p.id_pedido = ped.id_pedido;
                    p.fecha = ped.fecha;
                    p.detalle = ped.detalle;
                    p.monto = ped.monto;
                    p.cliente = ped.nombre;
                    p.producto = ped.nom_prod;
                    p.estado = ped.estado;
                    lstPedido.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }
            return lstPedido;
        }

        //get pedidos
        public List<Pedido> GetListaPedido()
        {
            List<Pedido> lstPedido = new List<Pedido>();
            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Pedido();

                foreach (var varPedido in varRespConsulta)
                {
                    Pedido _Pedido = new Pedido();
                    _Pedido.id_pedido = varPedido.id_pedido;
                    _Pedido.fecha = varPedido.fecha;
                    _Pedido.monto = varPedido.monto;
                    _Pedido.detalle = varPedido.detalle;
                    _Pedido.cliente = varPedido.nombre;
                    _Pedido.producto = varPedido.nom_prod;
                    _Pedido.estado = varPedido.estado;
                    lstPedido.Add(_Pedido);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }
            return lstPedido;
        }

        //get pedidos
        public List<Pedido> GetListaPedidoNoVigente()
        {
            List<Pedido> lstPedido = new List<Pedido>();
            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Pedido_NoVigente();

                foreach (var varPedido in varRespConsulta)
                {
                    Pedido _Pedido = new Pedido();
                    _Pedido.id_pedido = varPedido.id_pedido;
                    _Pedido.fecha = varPedido.fecha;
                    _Pedido.monto = varPedido.monto;
                    _Pedido.detalle = varPedido.detalle;
                    _Pedido.cliente = varPedido.nombre;
                    _Pedido.producto = varPedido.nom_prod;
                    _Pedido.estado = varPedido.estado;
                    lstPedido.Add(_Pedido);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }
            return lstPedido;
        }

        //Post Pedido
        public Pedido PostPedido(Pedido p)
        {
            try
            {
                int varRespConsulta = _bdEcommerceEntities.pa_Insertar_Pedido(p.fecha, p.monto, p.detalle, Convert.ToInt32(p.cliente), Convert.ToInt32(p.producto), p.estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return p;
        }
    }
}