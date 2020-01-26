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
    public class EstadisticaController : ApiController
    {
        [Route("api/PrecioTotal")]
        public int GetPrecioTotal()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetSumaProductos();
        }

        [Route("api/TotalStock")]
        public int GetStock()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetTotalStock();
        }

        [Route("api/IVAIncluido")]
        public List<Producto> GetIva()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetIvaIncluido();
        }

        [Route("api/IVAGrafico")]
        public List<int> GetIvaGrafico()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetIVAGrafico();
        }

        [Route("api/PrecioMaximo")]
        public int GetPrecioMaximo()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetPrecioMaximo();
        }

        [Route("api/TotalClientes")]
        public int GetTotalClientes()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetTotalClientes();
        }

        [Route("api/TotalUsuarios")]
        public int GetTotalUsuarios()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetTotalUsuarios();
        }

        [Route("api/SumaMontoPedidos")]
        public int GetSumaMontoPedidos()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetMontoPedidos();
        }

        [Route("api/MayorPedido")]
        public int GetMayorPedido()
        {
            NEstadisticas stat = new NEstadisticas(); 
            return stat.GetMayorPedido();
        }

        [Route("api/MenorPedido")]
        public int GetMenorPedido()
        {
            NEstadisticas stat = new NEstadisticas();
            return stat.GetMenorPedido();
        }
    }
}
