//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Connect.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Bank_Details
    {
        public int iU_B_Did { get; set; }
        public string iAccountNo { get; set; }
        public int iFK_Bank_DetailsId { get; set; }
    
        public virtual Bank_Details Bank_Details { get; set; }
    }
}
