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
    public class CategoriaController : ApiController
    {
        [Route("api/Categoria")]
        public List<Categoria> Get()
        {
            NCategoria nCategoria = new NCategoria();
            return nCategoria.GetListaCategoria();
        }

        [Route("api/Categoria/NoVigente")]
        public List<Categoria> GetA()
        {
            NCategoria nCategoria = new NCategoria();
            return nCategoria.GetListaCategoriaNoVigente();
        }

        [Route("api/Categoria/{id_categoria}")]
        public List<Categoria> Get(int id_categoria)
        {
            NCategoria nCategoria = new NCategoria();
            return nCategoria.GetCategoriaID(id_categoria);
        }

        [Route("api/Categoria")]
        public Categoria Post(Categoria c)
        {
            NCategoria nCategoria = new NCategoria();
            return nCategoria.PostCategoria(c);
        }

        [Route("api/Categoria/{id_categoria}")]
        public int Post(int id_categoria)
        {
            NCategoria nCategoria = new NCategoria();
            return nCategoria.DeleteCategoria(id_categoria);
        }

        [Route("api/Categoria/Activar/{id_categoria}")]
        public int PostP(int id_categoria)
        {
            NCategoria nCategoria = new NCategoria();
            return nCategoria.ActivarCategoria(id_categoria);
        }
    }
}
