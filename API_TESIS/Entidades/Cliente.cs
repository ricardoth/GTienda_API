using API_TESIS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Entidades
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string rut { get; set; }
        public string direccion { get; set; }
        public string fono { get; set; }
        public bool? estado { get; set; }
        public ETransaction ETransaction { get; set; }
    }
}