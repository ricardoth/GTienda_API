//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_TESIS.Models
{
    using System;
    
    public partial class pa_Listar_Pedido_NoVigente_Result
    {
        public int id_pedido { get; set; }
        public string fecha { get; set; }
        public string detalle { get; set; }
        public Nullable<int> monto { get; set; }
        public string nombre { get; set; }
        public string nom_prod { get; set; }
        public Nullable<bool> estado { get; set; }
    }
}