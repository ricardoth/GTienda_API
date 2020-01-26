using API_TESIS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Entidades
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nom_usuario { get; set; }
        public string pass { get; set; }
        public bool? estado { get; set; }
        public int? EXISTE { get; set; }
        public ETransaction ETransaction { get; set; }
    }
}