using API_TESIS.Negocio;
using API_TESIS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_TESIS.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PedidoController : ApiController
    {
        //Get pedidos
        [Route("api/Pedido")]
        public List<Pedido> Get()
        {
            NPedido nPedido = new NPedido();

            return nPedido.GetListaPedido();
        }

        //Get pedidos
        [Route("api/Pedido/NoVigente")]
        public List<Pedido> GetA()
        {
            NPedido nPedido = new NPedido();

            return nPedido.GetListaPedidoNoVigente();
        }

        //Get id 
        [Route("api/Pedido/{id_pedido}")]
        public List<Pedido> Get(int id_pedido)
        {
            NPedido nPedido = new NPedido();
            return nPedido.GetPedidoID(id_pedido);
        }

        //Post pedido
        [Route("api/Pedido")]
        public Pedido Post(Pedido p)
        {
            NPedido nPedido = new NPedido();
            return nPedido.PostPedido(p);
        }

        //Delete pedido
        [Route("api/Pedido/{id_pedido}")]
        public int Post(int id_pedido)
        {
            NPedido nPedido = new NPedido();
            return nPedido.DeletePedido(id_pedido);
        }

        //Activar
        [Route("api/Pedido/Activar/{id_pedido}")]
        public int PostP(int id_pedido)
        {
            NPedido nPedido = new NPedido();
            return nPedido.ActivarPedido(id_pedido);
        }
    }
}
