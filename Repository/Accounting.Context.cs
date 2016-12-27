﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class eBusinessEntities : DbContext
    {
        public eBusinessEntities()
            : base("name=eBusinessEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AccBudget> AccBudgets { get; set; }
        public DbSet<AccBudgetDetail> AccBudgetDetails { get; set; }
        public DbSet<AccChequePayment> AccChequePayments { get; set; }
        public DbSet<AccCustomerPayment> AccCustomerPayments { get; set; }
        public DbSet<AccGeneralLedger> AccGeneralLedgers { get; set; }
        public DbSet<AccGroup> AccGroups { get; set; }
        public DbSet<AccHead> AccHeads { get; set; }
        public DbSet<AccProject> AccProjects { get; set; }
        public DbSet<AccQuarterBudget> AccQuarterBudgets { get; set; }
        public DbSet<AccQuarterBudgetDetail> AccQuarterBudgetDetails { get; set; }
        public DbSet<AccSupplierPayment> AccSupplierPayments { get; set; }
        public DbSet<AccType> AccTypes { get; set; }
        public DbSet<AdjustmenDetail> AdjustmenDetails { get; set; }
        public DbSet<Adjustment> Adjustments { get; set; }
        public DbSet<AdjustmentType> AdjustmentTypes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<CashBook> CashBooks { get; set; }
        public DbSet<CheckInfo> CheckInfoes { get; set; }
        public DbSet<ChequeRegister> ChequeRegisters { get; set; }
        public DbSet<CompanyInfo> CompanyInfoes { get; set; }
        public DbSet<CountryInfo> CountryInfoes { get; set; }
        public DbSet<CRDR> CRDRs { get; set; }
        public DbSet<CRDRDetail> CRDRDetails { get; set; }
        public DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DistrictInfo> DistrictInfoes { get; set; }
        public DbSet<ExpenseInfo> ExpenseInfoes { get; set; }
        public DbSet<Inv_ColorInfo> Inv_ColorInfo { get; set; }
        public DbSet<Inv_SizeInfo> Inv_SizeInfo { get; set; }
        public DbSet<InvBrand> InvBrands { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PriceDeclarationDetail> PriceDeclarationDetails { get; set; }
        public DbSet<PriceDeclarationExpense> PriceDeclarationExpenses { get; set; }
        public DbSet<PriceDeclarationInfo> PriceDeclarationInfoes { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductInfo> ProductInfoes { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<ProductionConsum> ProductionConsums { get; set; }
        public DbSet<ProductionDetail> ProductionDetails { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<PurchaseRetrun> PurchaseRetruns { get; set; }
        public DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<SalesReturnDetail> SalesReturnDetails { get; set; }
        public DbSet<SupplierInfo> SupplierInfoes { get; set; }
        public DbSet<TarrifType> TarrifTypes { get; set; }
        public DbSet<TaxSource> TaxSources { get; set; }
        public DbSet<TblDesignation> TblDesignations { get; set; }
        public DbSet<TblDivision> TblDivisions { get; set; }
        public DbSet<tblUserReg> tblUserRegs { get; set; }
        public DbSet<tblWard> tblWards { get; set; }
        public DbSet<TreasuryPayment> TreasuryPayments { get; set; }
        public DbSet<TreasuryPaymentDetail> TreasuryPaymentDetails { get; set; }
        public DbSet<UnionInfo> UnionInfoes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UpojillaInfo> UpojillaInfoes { get; set; }
        public DbSet<VATType> VATTypes { get; set; }
        public DbSet<VD> VDS { get; set; }
        public DbSet<VillageInfo> VillageInfoes { get; set; }
        public DbSet<VoucherType> VoucherTypes { get; set; }
        public DbSet<vAccAccountDetail> vAccAccountDetails { get; set; }
        public DbSet<vAccBalanceSheet> vAccBalanceSheets { get; set; }
        public DbSet<vAccBudget> vAccBudgets { get; set; }
        public DbSet<vAccChartofAccount> vAccChartofAccounts { get; set; }
        public DbSet<vAccGeneralLedger> vAccGeneralLedgers { get; set; }
        public DbSet<vAccPrifitLose> vAccPrifitLoses { get; set; }
        public DbSet<vAccTrialBalance> vAccTrialBalances { get; set; }
    
        public virtual int spStockSummary(Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spStockSummary", startDateParameter, endDateParameter);
        }
    }
}