using API_TESIS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Entidades
{
    public class Categoria
    {
        public int id_categoria { get; set; }
        public string nom_categoria { get; set; }
        public bool? estado { get; set; }
        public ETransaction ETransaction { get; set; }
    }
}