//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eggplant
{
    using System;
    using System.Collections.Generic;
    
    public partial class LineaPedido
    {
        public int Id { get; set; }
        public int linea_oferta_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public int PedidoId { get; set; }
        public int sg_id { get; set; }
        public string state { get; set; }
    
        public virtual Pedido Pedido { get; set; }
    }
}
