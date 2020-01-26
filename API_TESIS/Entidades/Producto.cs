using API_TESIS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Entidades
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string nom_prod { get; set; }
        public string detalle { get; set; }
        public bool? estado { get; set; }
        public int? precio { get; set; }
        public int? stock { get; set; }
        public string categoria { get; set; }
    }
}