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
    
    public partial class FidelidadeCliente
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int Quantidade { get; set; }
        public int ProdutosFidelidadeId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ProdutosFidelidade ProdutosFidelidade { get; set; }
    }
}
