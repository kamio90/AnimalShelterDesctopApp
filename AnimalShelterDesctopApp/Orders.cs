//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimalShelterDesctopApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public int DogsRef { get; set; }
        public int ClientsRef { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Dogs Dogs { get; set; }
    }
}