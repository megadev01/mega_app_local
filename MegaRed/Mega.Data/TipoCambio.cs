//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mega.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoCambio
    {
        public TipoCambio()
        {
            this.CambioMoneda = new HashSet<CambioMoneda>();
            this.DepositoPrestamo = new HashSet<DepositoPrestamo>();
        }
    
        public System.DateTime Fecha { get; set; }
        public Nullable<decimal> ValorCambioCompra { get; set; }
        public Nullable<decimal> ValorCambioVenta { get; set; }
    
        public virtual ICollection<CambioMoneda> CambioMoneda { get; set; }
        public virtual ICollection<DepositoPrestamo> DepositoPrestamo { get; set; }
    }
}