using API_TESIS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Entidades
{
    public class Pedido
    {
        public int? id_pedido { get; set; }
        public string fecha { get; set; }
        public string detalle { get; set; }
        public int? monto { get; set; }
        public string cliente { get; set; }
        public string producto { get; set; }
        public bool? estado { get; set; }
        public ETransaction ETransaction { get; set; }
    }
}