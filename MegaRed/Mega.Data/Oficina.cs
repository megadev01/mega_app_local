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
    
    public partial class Oficina
    {
        public Oficina()
        {
            this.ContratoEmpresaAfiliado = new HashSet<ContratoEmpresaAfiliado>();
            this.MovimientoFondos = new HashSet<MovimientoFondos>();
            this.MovimientoFondos1 = new HashSet<MovimientoFondos>();
            this.Transferencia = new HashSet<Transferencia>();
            this.Transferencia1 = new HashSet<Transferencia>();
            this.Serie = new HashSet<Serie>();
        }
    
        public string CodigoOficina { get; set; }
        public string NombreOficina { get; set; }
        public string CodigoUbigeo { get; set; }
        public int TipoOficina { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
    
        public virtual ICollection<ContratoEmpresaAfiliado> ContratoEmpresaAfiliado { get; set; }
        public virtual ICollection<MovimientoFondos> MovimientoFondos { get; set; }
        public virtual ICollection<MovimientoFondos> MovimientoFondos1 { get; set; }
        public virtual ICollection<Transferencia> Transferencia { get; set; }
        public virtual ICollection<Transferencia> Transferencia1 { get; set; }
        public virtual ICollection<Serie> Serie { get; set; }
    }
}