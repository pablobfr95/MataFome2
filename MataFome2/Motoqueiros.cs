//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MataFome2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Motoqueiros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Motoqueiros()
        {
            this.Venda = new HashSet<Venda>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public double ValorTotalRecebido { get; set; }
        public double ValorEntrega { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venda> Venda { get; set; }
    }
}