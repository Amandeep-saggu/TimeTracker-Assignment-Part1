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
    
    public partial class TT_Customers
    {
        public TT_Customers()
        {
            this.TT_Projects = new HashSet<TT_Projects>();
        }
    
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
    
        public virtual TT_Users TT_Users { get; set; }
        public virtual ICollection<TT_Projects> TT_Projects { get; set; }
    }
}
