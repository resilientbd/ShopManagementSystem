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
    
    public partial class AccChequePayment
    {
        public int ChequePayID { get; set; }
        public System.DateTime Issue_Date { get; set; }
        public string TrnID { get; set; }
        public decimal BankID { get; set; }
        public decimal BranchID { get; set; }
        public string ChequeNo { get; set; }
        public decimal Cheque_Amount { get; set; }
        public string IsVoid { get; set; }
        public System.DateTime MaturityDate { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}