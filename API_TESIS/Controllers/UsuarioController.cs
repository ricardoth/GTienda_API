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
    public class UsuarioController : ApiController
    {
        [Route("api/Usuario")]
        public List<Usuario> Get()
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.GetListaUsuarios();
        }

        [Route("api/Usuario/NoVigente")]
        public List<Usuario> GetA()
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.GetListaUsuariosNoVigente();
        }

        [Route("api/Usuario/{id_usuario}")]
        public List<Usuario> Get(int id_usuario)
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.GetUsuarioID(id_usuario);
        }

        [Route("api/Login")]
        public int? PostLogin(Usuario u)
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.Login(u);
        }

        [Route("api/Usuario")]
        public Usuario Post(Usuario u)
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.PostUsuario(u);
        }

        [Route("api/Usuario/{id_usuario}")]
        public int Post(int id_usuario)
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.DeleteUsuario(id_usuario);
        }

        [Route("api/Usuario/Activar/{id_usuario}")]
        public int PostP(int id_usuario)
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.ActivarUsuario(id_usuario);
        }

    }
}
