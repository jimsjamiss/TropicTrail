//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TropicTrail
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tour_Type
    {
        public Tour_Type()
        {
            this.Services = new HashSet<Services>();
        }
    
        public int tbType_Id { get; set; }
        public string tbType_Name { get; set; }
    
        public virtual ICollection<Services> Services { get; set; }
    }
}