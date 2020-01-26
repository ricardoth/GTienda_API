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
    public class ClienteController : ApiController
    {
        [Route("api/Cliente")]
        public List<Cliente> Get()
        {
            NCliente Cliente = new NCliente();
            return Cliente.GetListaClientes();
        }

        [Route("api/NomCliente")]
        public List<Cliente> GetC()
        {
            NCliente Cliente = new NCliente();
            return Cliente.GetNombreClientes();
        }

        [Route("api/Cliente/NoVigente")]
        public List<Cliente> GetA()
        {
            NCliente Cliente = new NCliente();
            return Cliente.GetListaClientesNoVigente();
        }

        [Route("api/Cliente/{id_cliente}")]
        public List<Cliente> Get(int id_cliente)
        {
            NCliente Cliente = new NCliente();
            return Cliente.GetClienteID(id_cliente);
        }

        [Route("api/Cliente")]
        public Cliente Post(Cliente c)
        {
            NCliente Cliente = new NCliente();
            return Cliente.PostCliente(c);
        }

        [Route("api/Cliente/{id_cliente}")]
        public int Post(int id_cliente)
        {
            NCliente Cliente = new NCliente();
            return Cliente.DeleteCliente(id_cliente);
        }

        [Route("api/Cliente/Activar/{id_cliente}")]
        public int PostP(int id_cliente)
        {
            NCliente Cliente = new NCliente();
            return Cliente.ActivarCliente(id_cliente);
        }
    }
}
