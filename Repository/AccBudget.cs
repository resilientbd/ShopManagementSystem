//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccBudget
    {
        public int BudgetID { get; set; }
        public int CompanyID { get; set; }
        public string BudgetFor { get; set; }
        public System.DateTime BudgetDate { get; set; }
        public double TotalAmount { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string Modifier { get; set; }
        public System.DateTime ModificationDate { get; set; }
    }
}