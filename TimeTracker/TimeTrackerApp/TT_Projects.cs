//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTrackerApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TT_Projects
    {
        public TT_Projects()
        {
            this.TT_Enteries = new HashSet<TT_Enteries>();
        }
    
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public int CustomerID { get; set; }
    
        public virtual TT_Customers TT_Customers { get; set; }
        public virtual ICollection<TT_Enteries> TT_Enteries { get; set; }
    }
}