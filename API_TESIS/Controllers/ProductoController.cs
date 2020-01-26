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
    public class ProductoController : ApiController
    {
        [Route("api/Producto")]
        public List<Producto> Get()
        {
            NProducto nProducto = new NProducto();
            return nProducto.GetListaProductos();
        }

        [Route("api/Producto/NoVigente")]
        public List<Producto> GetA()
        {
            NProducto nProducto = new NProducto();

            return nProducto.GetListaProductosNoVigente();
        }

        [Route("api/Producto/{id_producto}")]
        public List<Producto> Get(int id_producto)
        {
            NProducto nProducto = new NProducto();
            return nProducto.GetProductoID(id_producto);
        }

        [Route("api/Producto")]
        public Producto Post(Producto p)
        {
            NProducto nProducto = new NProducto();
            return nProducto.PostProducto(p);
        }

        [Route("api/Producto/{id_producto}")]
        public int Post(int id_producto)
        {
            NProducto nProducto = new NProducto();
            return nProducto.DeleteProducto(id_producto);
        }

        [Route("api/Producto/Activar/{id_producto}")]
        public int PostP(int id_producto)
        {
            NProducto nProducto = new NProducto();
            return nProducto.ActivarProducto(id_producto);
        }

        [Route("api/Producto/ComboID")]
        public List<int> GetComboID()
        {
            NProducto nProducto = new NProducto();
            return nProducto.GetComboIDCategoria();
        }
        [Route("api/Producto/Combo")]
        public List<string> GetCombo()
        {
            NProducto nProducto = new NProducto();
            return nProducto.GetComboCategoria();
        }
    }
}
