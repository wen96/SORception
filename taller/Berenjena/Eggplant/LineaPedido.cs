//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eggplant
{
    using System;
    using System.Collections.Generic;
    
    public partial class LineaPedido
    {
        public int Id { get; set; }
        public string oferta_id { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public int PedidoId { get; set; }
    
        public virtual Pedido Pedido { get; set; }
    }
}
