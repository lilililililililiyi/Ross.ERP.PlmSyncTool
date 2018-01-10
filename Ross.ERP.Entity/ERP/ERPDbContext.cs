namespace Ross.ERP.Entity.ERP
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Model;

    public partial class ERPDbContext : DbContext
    {
        public ERPDbContext(string ConnStr = "ERPDbContext")
            : base("name=" + ConnStr + "")
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Company_UD> Company_UD { get; set; }
        public virtual DbSet<DMRActn> DMRActn { get; set; }
        public virtual DbSet<DMRHead> DMRHead { get; set; }
        public virtual DbSet<EmpBasic> EmpBasic { get; set; }
        public virtual DbSet<JobAsmbl> JobAsmbl { get; set; }
        public virtual DbSet<JobHead> JobHead { get; set; }
        public virtual DbSet<JobHead_UD> JobHead_UD { get; set; }
        public virtual DbSet<JobMtl> JobMtl { get; set; }
        public virtual DbSet<JobMtl_UD> JobMtl_UD { get; set; }
        public virtual DbSet<JobOpDtl> JobOpDtl { get; set; }
        public virtual DbSet<JobOper> JobOper { get; set; }
        public virtual DbSet<JobOper_UD> JobOper_UD { get; set; }
        public virtual DbSet<JobPart> JobPart { get; set; }
        public virtual DbSet<OrderDtl> OrderDtl { get; set; }
        public virtual DbSet<OrderHed> OrderHed { get; set; }
        public virtual DbSet<OrderHed_UD> OrderHed_UD { get; set; }
        public virtual DbSet<OrderMsc> OrderMsc { get; set; }
        public virtual DbSet<OrderRel> OrderRel { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<Part_UD> Part_UD { get; set; }
        public virtual DbSet<PartAlloc> PartAlloc { get; set; }
        public virtual DbSet<PartBin> PartBin { get; set; }
        public virtual DbSet<PartBinInfo> PartBinInfo { get; set; }
        public virtual DbSet<PartBOM> PartBOM { get; set; }
        public virtual DbSet<PartBOO> PartBOO { get; set; }
        public virtual DbSet<PartClass> PartClass { get; set; }
        public virtual DbSet<PartClassPlt> PartClassPlt { get; set; }
        public virtual DbSet<PartCOO> PartCOO { get; set; }
        public virtual DbSet<PartCost> PartCost { get; set; }
        public virtual DbSet<PartDtl> PartDtl { get; set; }
        public virtual DbSet<PartMtl> PartMtl { get; set; }
        public virtual DbSet<PartMtlInsp> PartMtlInsp { get; set; }
        public virtual DbSet<PartOpDtl> PartOpDtl { get; set; }
        public virtual DbSet<PartOpr> PartOpr { get; set; }
        public virtual DbSet<PartOprInsp> PartOprInsp { get; set; }
        public virtual DbSet<PartTran> PartTran { get; set; }
        public virtual DbSet<PartTran_UD> PartTran_UD { get; set; }
        public virtual DbSet<Plant> Plant { get; set; }
        public virtual DbSet<PlantTran> PlantTran { get; set; }
        public virtual DbSet<PlantWhse> PlantWhse { get; set; }
        public virtual DbSet<PODetail> PODetail { get; set; }
        public virtual DbSet<PODetail_UD> PODetail_UD { get; set; }
        public virtual DbSet<PODetailInsp> PODetailInsp { get; set; }
        public virtual DbSet<POHeader> POHeader { get; set; }
        public virtual DbSet<POHeaderTax> POHeaderTax { get; set; }
        public virtual DbSet<POMisc> POMisc { get; set; }
        public virtual DbSet<PORel> PORel { get; set; }
        public virtual DbSet<PORel_UD> PORel_UD { get; set; }
        public virtual DbSet<RcvDtl> RcvDtl { get; set; }
        public virtual DbSet<RcvHead> RcvHead { get; set; }
        public virtual DbSet<RcvMisc> RcvMisc { get; set; }
        public virtual DbSet<Reason> Reason { get; set; }
        public virtual DbSet<ShipDtl> ShipDtl { get; set; }
        public virtual DbSet<ShipDtlInfo> ShipDtlInfo { get; set; }
        public virtual DbSet<ShipHead> ShipHead { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendPart> VendPart { get; set; }
        public virtual DbSet<WhseBin> WhseBin { get; set; }
        public virtual DbSet<UserFile> UserFile { get; set; }
        public virtual DbSet<OpMaster> OpMaster { get; set; }
        public virtual DbSet<SyncHistory> SyncHistory { get; set; }
        public virtual DbSet<StockPart> StockPart { get; set; }
        public virtual DbSet<PartRev> PartRev { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<DMRActn>()
                .Property(e => e.Quantity)
                .HasPrecision(22, 8);

            modelBuilder.Entity<DMRActn>()
                .Property(e => e.UnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRActn>()
                .Property(e => e.DocUnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRActn>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(20, 10);

            modelBuilder.Entity<DMRActn>()
                .Property(e => e.Rpt1UnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRActn>()
                .Property(e => e.Rpt2UnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRActn>()
                .Property(e => e.Rpt3UnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRActn>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.TotDiscrepantQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.TotRejectedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.TotAcceptedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.AvgMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.AvgLbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.AvgBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.AvgSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.AvgMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.MaterialMtlCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.MaterialLabCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.MaterialSubCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.MaterialBurCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<DMRHead>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<EmpBasic>()
                .Property(e => e.LaborRate)
                .HasPrecision(14, 4);

            modelBuilder.Entity<EmpBasic>()
                .Property(e => e.DefaultLaborHrs)
                .HasPrecision(11, 5);

            modelBuilder.Entity<EmpBasic>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.QtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.RequiredQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.PullQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.MtlBurRate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.EstUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.EstMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.OverRunQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.StartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.DueHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TotalCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.MtlBurCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.IssuedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.WIStartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.WIDueHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLALaborCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLABurdenCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMaterialCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLASubcontractCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMtlBurCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLASetupHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAProdHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLELaborCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLEBurdenCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLEMaterialCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLESubcontractCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLEMtlBurCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLESetupHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLEProdHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLALaborCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLABurdenCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMaterialCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLASubcontractCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMtlBurCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLASetupHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAProdHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLELaborCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLEBurdenCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLEMaterialCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLESubcontractCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLEMtlBurCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLESetupHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLEProdHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.ReceivedToStock)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMaterialLabCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMaterialMtlCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMaterialSubCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMaterialBurCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMaterialLabCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMaterialMtlCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMaterialSubCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMaterialBurCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TotalMtlMtlCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TotalMtlLabCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TotalMtlSubCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TotalMtlBurCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.OrigRequiredQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMaterialMtlBurCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMaterialMtlBurCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMfgCompLabCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMfgCompMtlCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMfgCompSubCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMfgCompBurCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAMfgCompMtlBurCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMfgCompLabCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMfgCompMtlCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMfgCompSubCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMfgCompBurCost)
                .HasPrecision(16, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.LLAMfgCompMtlBurCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.Weight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.EstMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.EstLbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.EstBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.EstSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.EstScrap)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.TLAODCCost)
                .HasPrecision(19, 5);

            modelBuilder.Entity<JobAsmbl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobHead>()
                .Property(e => e.ProdQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.StartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.DueHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.UserDecimal1)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.UserDecimal2)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.WIStartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.WIDueHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.QtyCompleted)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.OrigProdQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobHead>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobHead>()
                .HasOptional(e => e.JobHead_UD)
                .WithRequired(e => e.JobHead)
                .WillCascadeOnDelete();

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.UD_SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number01_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number02_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number03_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number04_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number05_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number06_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number07_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number08_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number09_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number10_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number11_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number12_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number13_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number14_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number15_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number16_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number17_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number18_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number19_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobHead_UD>()
                .Property(e => e.Number20_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.QtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.RequiredQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.MtlBurRate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.EstMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.EstUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.IssuedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.TotalCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.MtlBurCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageQtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageMtlBurRate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageUnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageEstMtlBurUnitCredit)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageQtyToDate)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageCredit)
                .HasPrecision(15, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageMtlBurCredit)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.EstScrap)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.MaterialMtlCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.MaterialLabCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.MaterialSubCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.MaterialBurCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageMtlCredit)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageLbrCredit)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageBurCredit)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageSubCredit)
                .HasPrecision(17, 3);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.BillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.DocBillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.ShippedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.DocUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.QtyStagedToDate)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.Rpt1BillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.Rpt2BillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.Rpt3BillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.Rpt1UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.Rpt2UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.Rpt3UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.BaseRequiredQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.Weight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.EstMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.EstLbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.EstBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.EstSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageEstMtlUnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageEstLbrUnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageEstBurUnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SalvageEstSubUnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.LoanedQty)
                .HasPrecision(16, 2);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.BorrowedQty)
                .HasPrecision(16, 2);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.POCostingFactor)
                .HasPrecision(14, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.PlannedQtyPerUnit)
                .HasPrecision(14, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.POCostingUnitVal)
                .HasPrecision(14, 5);

            modelBuilder.Entity<JobMtl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobMtl>()
                .HasOptional(e => e.JobMtl_UD)
                .WithRequired(e => e.JobMtl)
                .WillCascadeOnDelete();

            modelBuilder.Entity<JobMtl_UD>()
                .Property(e => e.UD_SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobMtl_UD>()
                .Property(e => e.StandByQty_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobMtl_UD>()
                .Property(e => e.AppMtlQty_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobMtl_UD>()
                .Property(e => e.PrepMtlQty_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobMtl_UD>()
                .Property(e => e.PrepMtlNeedQty_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ConcurrentCapacity)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.DailyProdRate)
                .HasPrecision(17, 6);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.EstSetHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.EstProdHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ProdStandard)
                .HasPrecision(18, 8);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ProdLabRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.SetupLabRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ProdBurRate)
                .HasPrecision(17, 6);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.SetupBurRate)
                .HasPrecision(17, 6);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ActProdHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ActProdRwkHours)
                .HasPrecision(8, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ActSetupHours)
                .HasPrecision(8, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ActSetupRwkHours)
                .HasPrecision(8, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ActBurCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ActLabCost)
                .HasPrecision(16, 3);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ReworkBurCost)
                .HasPrecision(16, 3);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ReworkLabCost)
                .HasPrecision(16, 3);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.EstSetHoursPerMch)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.ProdCrewSize)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.SetUpCrewSize)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOpDtl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobOper>()
                .Property(e => e.EstSetHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.EstProdHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ProdStandard)
                .HasPrecision(18, 8);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.QtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.QueStartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.StartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.DueHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.MoveDueHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ProdLabRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.SetupLabRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ProdBurRate)
                .HasPrecision(17, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.SetupBurRate)
                .HasPrecision(17, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.SetUpCrewSize)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ProdCrewSize)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ActProdHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ActProdRwkHours)
                .HasPrecision(8, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ActSetupHours)
                .HasPrecision(8, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ActSetupRwkHours)
                .HasPrecision(8, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.QtyCompleted)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.EstScrap)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.EstUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.DaysOut)
                .HasPrecision(7, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.RunQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.WIQueStartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.WIStartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.WIDueHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.WIMoveDueHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.WIHoursPerMachine)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.WILoadHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ActBurCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ActLabCost)
                .HasPrecision(16, 3);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ReworkBurCost)
                .HasPrecision(16, 3);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ReworkLabCost)
                .HasPrecision(16, 3);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.MiscAmt)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.HoursPerMachine)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.LoadHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.EstSetHoursPerMch)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.LaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.BillableLaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.DocLaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.DocBillableLaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.BillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.DocBillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.DocUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.FAQty)
                .HasPrecision(14, 8);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.QtyStagedToDate)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.BookedUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt1BillableLaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt2BillableLaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt3BillableLaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt1BillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt2BillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt3BillableUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt1LaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt2LaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt3LaborRate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt1UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt2UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Rpt3UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.Weight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.SendAheadOffset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.TearDwnEndHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.WITearDwnEndHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ActualStartHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ActualEndHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.PctReg)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.SetupMaterial)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ExpPctUp)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ExpCycTm)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.ExpGood)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.NonProdLimit)
                .HasPrecision(15, 5);

            modelBuilder.Entity<JobOper>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobOper>()
                .HasOptional(e => e.JobOper_UD)
                .WithRequired(e => e.JobOper)
                .WillCascadeOnDelete();

            modelBuilder.Entity<JobOper_UD>()
                .Property(e => e.UD_SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<JobPart>()
                .Property(e => e.PartQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.StockQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.ShippedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.ReceivedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.WIPQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.QtyCompleted)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.ReservedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.AllocatedQty900)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.PickingQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.PickedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<JobPart>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.OrderQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Discount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.AdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocAdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.SellingFactor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.SellingQuantity)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.CumeQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.ConfigUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.ConfigBaseUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.PricingQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.ListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.OrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocOrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.PricingValue)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DisplaySeq)
                .HasPrecision(9, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.KitQtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.RepRate1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.RepRate2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.RepRate3)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.RepRate4)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.RepRate5)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1Discount)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2Discount)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3Discount)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1AdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2AdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3AdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1ListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2ListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3ListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1OrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2OrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3OrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.ExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1ExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2ExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3ExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.InUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocInUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.InDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocInDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.InListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocInListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.InOrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocInOrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1InUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2InUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3InUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1InDiscount)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2InDiscount)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3InDiscount)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1InListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2InListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3InListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1InOrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2InOrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3InOrdBasedPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.InExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocInExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1InExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2InExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3InExtPriceDtl)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.OldOurOpenQty)
                .HasPrecision(16, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.OldSellingOpenQty)
                .HasPrecision(16, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.OldOpenValue)
                .HasPrecision(16, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.PrevSellQty)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DiscListPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.UndersPct)
                .HasPrecision(14, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Overs)
                .HasPrecision(14, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Unders)
                .HasPrecision(14, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.OversUnitPrice)
                .HasPrecision(14, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.DocInAdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.InAdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt1InAdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt2InAdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderDtl>()
                .Property(e => e.Rpt3InAdvanceBillBal)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DepositBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocDepositBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CreditOverrideLimit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(20, 10);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CCAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CCFreight)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CCTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CCTotal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CCDocAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CCDocFreight)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CCDocTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CCDocTotal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.RepRate4)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.RepRate5)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.RepRate1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.RepRate2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.RepRate3)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.ChrgAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.CODAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DeclaredAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalComm)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalAdvBill)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocTotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocTotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocTotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocTotalComm)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocTotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocTotalAdvBill)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalShipped)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalInvoiced)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommAmt1)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommAmt2)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommAmt3)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommAmt4)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommAmt5)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommableAmt1)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommableAmt2)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommableAmt3)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommableAmt4)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SRCommableAmt5)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rounding)
                .HasPrecision(16, 5);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1DepositBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocRounding)
                .HasPrecision(16, 5);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2DepositBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3DepositBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1TotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2TotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3TotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1TotalAdvBill)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2TotalAdvBill)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3TotalAdvBill)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1TotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2TotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3TotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1TotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2TotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3TotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1TotalComm)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2TotalComm)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3TotalComm)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1Rounding)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2Rounding)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3Rounding)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1CCAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2CCAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3CCAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1CCFreight)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2CCFreight)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3CCFreight)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1CCTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2CCTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3CCTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1CCTotal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2CCTotal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3CCTotal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.OrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocOrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1OrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2OrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3OrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocTotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1TotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2TotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3TotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocTotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.InTotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.InTotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.InTotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocInTotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocInTotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.DocInTotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1InTotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2InTotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3InTotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1InTotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2InTotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3InTotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt1InTotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt2InTotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.Rpt3InTotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.UserDecimal1)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.UserDecimal2)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.OrderOpenCredit)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed>()
                .Property(e => e.ClosedNotShipped)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderHed_UD>()
                .Property(e => e.UD_SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<OrderHed_UD>()
                .Property(e => e.changzhi_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderHed_UD>()
                .Property(e => e.Number01_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderHed_UD>()
                .Property(e => e.Number02_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderHed_UD>()
                .Property(e => e.Number03_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderHed_UD>()
                .Property(e => e.Number04_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderHed_UD>()
                .Property(e => e.Number05_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.MiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.DocMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.Rpt1MiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.Rpt2MiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.Rpt3MiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.InMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.DocInMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.Rpt1InMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.Rpt2InMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.Rpt3InMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.Percentage)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.ChangeTrackAmount)
                .HasPrecision(14, 5);

            modelBuilder.Entity<OrderMsc>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.OurReqQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.OurJobQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.OurJobShippedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.OurStockQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.OurStockShippedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.SellingReqQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.SellingJobQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.SellingJobShippedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.SellingStockQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.SellingStockShippedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.CumeQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.ChrgAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.CODAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.DeclaredAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.PrevSellQty)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.WIItemPrice)
                .HasPrecision(14, 5);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.WIItemShipCost)
                .HasPrecision(14, 5);

            modelBuilder.Entity<OrderRel>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<Part>()
                .Property(e => e.PurchasingFactor)
                .HasPrecision(14, 4);

            modelBuilder.Entity<Part>()
                .Property(e => e.UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.InternalUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.UserDecimal1)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Part>()
                .Property(e => e.UserDecimal2)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Part>()
                .Property(e => e.UserDecimal3)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.UserDecimal4)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.SellingFactor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<Part>()
                .Property(e => e.MtlBurRate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.NetWeight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.PartLength)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.PartWidth)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.PartHeight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.Diameter)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.Gravity)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.ISSuppUnitsFactor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<Part>()
                .Property(e => e.NetVolume)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.RCUnderThreshold)
                .HasPrecision(17, 3);

            modelBuilder.Entity<Part>()
                .Property(e => e.RCOverThreshold)
                .HasPrecision(17, 3);

            modelBuilder.Entity<Part>()
                .Property(e => e.GrossWeight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.FSSalesUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.PricingFactor)
                .HasPrecision(14, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<Part>()
                .Property(e => e.DiameterInside)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.DiameterOutside)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.Thickness)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part>()
                .Property(e => e.ThicknessMax)
                .HasPrecision(15, 5);

            modelBuilder.Entity<Part_UD>()
                .Property(e => e.UD_SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<Part_UD>()
                .Property(e => e.CustomsDuties_c)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PartAlloc>()
                .Property(e => e.ReservedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartAlloc>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartAlloc>()
                .Property(e => e.PickingQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartAlloc>()
                .Property(e => e.PickedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartAlloc>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartBin>()
                .Property(e => e.OnhandQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.SalesAllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.SalesPickingQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.SalesPickedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.JobAllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.JobPickingQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.JobPickedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.TFOrdAllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.TFOrdPickingQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.TFOrdPickedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.ShippingQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.PackedQty)
                .HasPrecision(16, 2);

            modelBuilder.Entity<PartBin>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartBinInfo>()
                .Property(e => e.MinimumQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBinInfo>()
                .Property(e => e.MaximumQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBinInfo>()
                .Property(e => e.SafetyQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBinInfo>()
                .Property(e => e.OnhandQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBinInfo>()
                .Property(e => e.KBQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartBinInfo>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.QtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.QtyRequired)
                .HasPrecision(19, 8);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.TLRLaborCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.TLRBurdenCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.TLRMaterialCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.TLRSubcontractCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.TLRMtlBurCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.TLRSetupLaborCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.TLRSetupBurdenCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.LLRLaborCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.LLRBurdenCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.LLRMaterialCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.LLRSubcontractCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.LLRMtlBurCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.LLRSetupLaborCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.LLRSetupBurdenCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.SalvageQtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.SalvageUnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartBOM>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartBOO>()
                .Property(e => e.QtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartBOO>()
                .Property(e => e.QtyRequired)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PartBOO>()
                .Property(e => e.EstSetHours)
                .HasPrecision(8, 2);

            modelBuilder.Entity<PartBOO>()
                .Property(e => e.EstProdHours)
                .HasPrecision(11, 5);

            modelBuilder.Entity<PartBOO>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartClass>()
                .Property(e => e.MtlBurRate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<PartClass>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartClass>()
                .Property(e => e.MMSMaxFactor)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PartClassPlt>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartCOO>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartCost>()
                .Property(e => e.AvgLaborCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.AvgBurdenCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.AvgMaterialCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.AvgSubContCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.AvgMtlBurCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.StdLaborCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.StdBurdenCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.StdMaterialCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.StdSubContCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.StdMtlBurCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.LastLaborCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.LastBurdenCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.LastMaterialCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.LastSubContCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.LastMtlBurCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.FIFOAvgLaborCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.FIFOAvgBurdenCost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.FIFOAvgMaterialCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.FIFOAvgSubContCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.FIFOAvgMtlBurCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartCost>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartCost>()
                .Property(e => e.TotalQtyAvg)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartDtl>()
                .Property(e => e.Quantity)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartDtl>()
                .Property(e => e.BaseQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartDtl>()
                .Property(e => e.InvtyQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartDtl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.QtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.SalvageQtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.SalvageUnitCredit)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.EstScrap)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.APSSLTime)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.APSAttrib1)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.APSAttrib2)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.APSAttrib3)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.APSAttrib4)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.SalvageMtlBurRate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.SalvageEstMtlBurUnitCredit)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.MtlBurRate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.EstMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.Weight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartMtl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartMtlInsp>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartOpDtl>()
                .Property(e => e.SetupHours)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartOpDtl>()
                .Property(e => e.ProdHours)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpDtl>()
                .Property(e => e.ConcurrentCapacity)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartOpDtl>()
                .Property(e => e.DailyProdRate)
                .HasPrecision(17, 6);

            modelBuilder.Entity<PartOpDtl>()
                .Property(e => e.ProdCrewSize)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PartOpDtl>()
                .Property(e => e.SetUpCrewSize)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PartOpDtl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.EstSetHours)
                .HasPrecision(8, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.EstProdHours)
                .HasPrecision(11, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.ProdStandard)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.QtyPer)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.SetUpCrewSize)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.ProdCrewSize)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.EstScrap)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.EstUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.DaysOut)
                .HasPrecision(7, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.RunQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.AddlSetupHours)
                .HasPrecision(7, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.AddlSetUpQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.APSCycleTime)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.APSConstantTime)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.APSContainerSize)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.APSMaxLength)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.APSTransferTime)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.APSEffectiveness)
                .HasPrecision(13, 3);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.FAQty)
                .HasPrecision(14, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost01)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost02)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost03)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost04)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost05)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost06)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost07)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost08)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost09)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkCost10)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate01)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate02)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate03)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate04)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate05)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate06)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate07)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate08)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate09)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PBrkStdRate10)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty01)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty02)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty03)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty04)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty05)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty06)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty07)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty08)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty09)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.BrkQty10)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.Weight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.SendAheadOffset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.PctReg)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.SetupMaterial)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.ExpPctUp)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.ExpCycTm)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.ExpGood)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.NonProdLimit)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartOpr>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartOprInsp>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartTran>()
                .Property(e => e.TranQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.MtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.LbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.BurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.SubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.MtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.POReceiptQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.POUnitCost)
                .HasPrecision(15, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.DimConvFactor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.DimConvFactor2)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.OtherDivValue)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.MtlMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.MtlLabUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.MtlSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.MtlBurdenUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.BeginQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AfterQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.BegBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.BegLbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.BegMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.BegMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.BegSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AfterBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AfterLbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AfterMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AfterMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AfterSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.PlantCostValue)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ActTranQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltLbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltExtCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltMtlMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltMtlLabUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltMtlSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.AltMtlBurdenUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ODCUnitCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtMtlCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtLbrCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtBurCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtSubCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtMtlBurCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtMtlMtlCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtMtlLabCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtMtlSubCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .Property(e => e.ExtMtlBurdenCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PartTran>()
                .HasOptional(e => e.PartTran_UD)
                .WithRequired(e => e.PartTran)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PartTran_UD>()
                .Property(e => e.UD_SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<Plant>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.TranQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.DimConvFactor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.MtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.LbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.BurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.SubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.MtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.InternalPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.MtlMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.MtlLabUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.MtlSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.MtlBurdenUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.MtlMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltLbrUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltMtlMtlUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltMtlLabUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltMtlSubUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.AltMtlBurdenUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PlantTran>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PlantWhse>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PODetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.DocUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.OrderQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.XOrderQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.AdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.DocAdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.PrcChgReq)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.ContractQty)
                .HasPrecision(19, 8);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.ContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.ContractDocUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt1AdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt2AdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt3AdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt1UnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt2UnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt3UnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt1ContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt2ContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt3ContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.BaseQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.ConfigUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.ConfigBaseUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Factor)
                .HasPrecision(14, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.PricingQty)
                .HasPrecision(14, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.PricingUnitPrice)
                .HasPrecision(14, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PODetail>()
                .Property(e => e.DocPricingUnitPrice)
                .HasPrecision(14, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.SelCurrPricingUnitPrice)
                .HasPrecision(14, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.InUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.DocInUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt1InUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt2InUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt3InUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.InAdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.DocInAdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt1InAdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt2InAdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt3InAdvancePayBal)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.InContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.DocInContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt1InContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt2InContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt3InContractUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.DocExtCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.ExtCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt1ExtCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt2ExtCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt3ExtCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.DocMiscCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.MiscCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt1MiscCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt2MiscCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail>()
                .Property(e => e.Rpt3MiscCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PODetail_UD>()
                .Property(e => e.UD_SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PODetail_UD>()
                .Property(e => e.TaxedAmt_c)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PODetailInsp>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<POHeader>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(20, 10);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.ApprovedAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<POHeader>()
                .Property(e => e.TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.DocTotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt1TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt2TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt3TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.TotalWhTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.DocTotalWhTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt1TotalWhTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt2TotalWhTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt3TotalWhTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.DocTotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt1TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt2TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt3TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.TotalDedTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.DocTotalDedTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt1TotalDedTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt2TotalDedTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt3TotalDedTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.TotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.TotalMiscCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.TotalOrder)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.DocTotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.DocTotalMisc)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.DocTotalOrder)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt1TotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt2TotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt3TotalCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt1TotalMiscCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt2TotalMiscCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt3TotalMiscCharges)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt1TotalOrder)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt2TotalOrder)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .Property(e => e.Rpt3TotalOrder)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeader>()
                .HasMany(e => e.POHeaderTax)
                .WithRequired(e => e.POHeader)
                .HasForeignKey(e => new { e.Company, e.PONum });

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.ReportableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DocReportableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.TaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DocTaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Percent)
                .HasPrecision(10, 5);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.TaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DocTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt1ReportableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt2ReportableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt3ReportableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt1TaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt2TaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt3TaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt1TaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt2TaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt3TaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.ExemptPercent)
                .HasPrecision(7, 2);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DefTaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DocDefTaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt1DefTaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt2DefTaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt3DefTaxableAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DefTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DocDefTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt1DefTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt2DefTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt3DefTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DedTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DocDedTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt1DedTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt2DedTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt3DedTaxAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.FixedAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DocFixedAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt1FixedAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt2FixedAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt3FixedAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.TaxAmtVar)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.DocTaxAmtVar)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt1TaxAmtVar)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt2TaxAmtVar)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.Rpt3TaxAmtVar)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POHeaderTax>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<POMisc>()
                .Property(e => e.MiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.DocMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.InvoicedAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.DocInvoicedAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt1InvoicedAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt2InvoicedAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt3InvoicedAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt1MiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt2MiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt3MiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Percentage)
                .HasPrecision(7, 2);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<POMisc>()
                .Property(e => e.InMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.DocInMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt1InMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt2InMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt3InMiscAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.InInvoiceAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.DocInInvoiceAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt1InInvoiceAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt2InInvoiceAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<POMisc>()
                .Property(e => e.Rpt3InInvoiceAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<PORel>()
                .Property(e => e.XRelQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.PurchasingFactor)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PORel>()
                .Property(e => e.RelQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.ReceivedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.ReqChgQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.ShippedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.BaseQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.SMIRcvdQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<PORel>()
                .Property(e => e.SMIRemQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.ArrivedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.InvoicedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.InspectionQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.FailedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .Property(e => e.PassedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<PORel>()
                .HasOptional(e => e.PORel_UD)
                .WithRequired(e => e.PORel)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PORel_UD>()
                .Property(e => e.UD_SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.OurQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.OurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.VendorQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.VendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.DimConvFactor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.PassedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.FailedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.TotCostVariance)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Weight)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.MtlBurRate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.OurMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.DocUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Volume)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt1UnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt2UnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt3UnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.UpliftPercent)
                .HasPrecision(7, 2);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.LCDutyAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.LCIndCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.POTransValue)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.ExtTransValue)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.LCSpecLineDutyAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.AppliedRcptLCAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.LCUpliftIndCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.LCAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.AppliedLCVariance)
                .HasPrecision(13, 3);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.LCMtlBurUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.DocVendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt1VendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt2VendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt3VendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.GrossWeight)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.InOurCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.DocInUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt1InUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt2InUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt3InUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.InVendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.DocInVendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt1InVendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt2InVendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.Rpt3InVendorUnitCost)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.SupplierUnInvcReceiptQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<RcvDtl>()
                .Property(e => e.OurUnInvcReceiptQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.LandedCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.LCVariance)
                .HasPrecision(13, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.Weight)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.UpliftPercent)
                .HasPrecision(7, 2);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.SpecDutyAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.AppliedLCAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.LCDutyAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.LCIndCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.AppliedRcptLCAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.LCUpliftIndCost)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.AppliedLCVariance)
                .HasPrecision(13, 3);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.GrossWeight)
                .HasPrecision(17, 5);

            modelBuilder.Entity<RcvHead>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<RcvMisc>()
                .Property(e => e.ActualAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvMisc>()
                .Property(e => e.DocActualAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvMisc>()
                .Property(e => e.Rpt1ActualAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvMisc>()
                .Property(e => e.Rpt2ActualAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvMisc>()
                .Property(e => e.Rpt3ActualAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RcvMisc>()
                .Property(e => e.Percentage)
                .HasPrecision(7, 2);

            modelBuilder.Entity<RcvMisc>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<Reason>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.OurInventoryShipQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.OurJobShipQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.DimConvFactor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.SellingInventoryShipQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.SellingJobShipQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.SellingFactor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.TotalNetWeight)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Discount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.DocDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt1Discount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt2Discount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt3Discount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.ExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.DocExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt1ExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt2ExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt3ExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.DocUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt1UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt2UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt3UnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.PickedAutoAllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.InDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.DocInDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt1InDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt2InDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt3InDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.InExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.DocInExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt1InExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt2InExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt3InExtPrice)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.InUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.DocInUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt1InUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt2InUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.Rpt3InUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.AllowedOvers)
                .HasPrecision(14, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.AllowedUnders)
                .HasPrecision(14, 5);

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<ShipDtl>()
                .Property(e => e.NotAllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtl>()
                .HasMany(e => e.ShipDtlInfo)
                .WithRequired(e => e.ShipDtl)
                .HasForeignKey(e => new { e.Company, e.PackNum, e.PackLine });

            modelBuilder.Entity<ShipDtlInfo>()
                .Property(e => e.OurInventoryShipQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtlInfo>()
                .Property(e => e.OurJobShipQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtlInfo>()
                .Property(e => e.SellingInventoryShipQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtlInfo>()
                .Property(e => e.SellingJobShipQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtlInfo>()
                .Property(e => e.PickedAutoAllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtlInfo>()
                .Property(e => e.NotAllocatedQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<ShipDtlInfo>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Weight)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.ChrgAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.CODAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.DeclaredAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.MFDiscFreight)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.MFDimWeight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.MFFreightAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.MFOtherAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.PkgLength)
                .HasPrecision(15, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.PkgWidth)
                .HasPrecision(15, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.PkgHeight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rounding)
                .HasPrecision(16, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt1Rounding)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt2Rounding)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt3Rounding)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.DocRounding)
                .HasPrecision(16, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt1TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt2TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt3TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.OrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.DocOrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt1OrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt2OrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt3OrderAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.TotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.DocTotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt1TotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt2TotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt3TotalWHTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.DocTotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt1TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt2TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt3TotalSATax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.TotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.DocTotalTax)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.TotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt1TotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt2TotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.Rpt3TotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.DocTotalDiscount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.ManifestWeight)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.ManifestLength)
                .HasPrecision(15, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.ManifestWidth)
                .HasPrecision(15, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.ManifestHeight)
                .HasPrecision(15, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.ReconcileQty)
                .HasPrecision(17, 5);

            modelBuilder.Entity<ShipHead>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<Vendor>()
                .Property(e => e.MinOrderValue)
                .HasPrecision(17, 3);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ChrgAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.CODAmount)
                .HasPrecision(17, 3);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.DeclaredAmt)
                .HasPrecision(17, 3);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<VendPart>()
                .Property(e => e.BaseUnitPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<VendPart>()
                .Property(e => e.MinimumPrice)
                .HasPrecision(17, 5);

            modelBuilder.Entity<VendPart>()
                .Property(e => e.MiscAmt)
                .HasPrecision(13, 3);

            modelBuilder.Entity<VendPart>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(6, 2);

            modelBuilder.Entity<VendPart>()
                .Property(e => e.OnhandQty)
                .HasPrecision(22, 8);

            modelBuilder.Entity<VendPart>()
                .Property(e => e.ConvFactor)
                .HasPrecision(17, 7);

            modelBuilder.Entity<VendPart>()
                .Property(e => e.SysRevID)
                .IsFixedLength();

            modelBuilder.Entity<WhseBin>()
                .Property(e => e.MaxFill)
                .HasPrecision(12, 2);

            modelBuilder.Entity<WhseBin>()
                .Property(e => e.PctFillable)
                .HasPrecision(7, 2);

            modelBuilder.Entity<WhseBin>()
                .Property(e => e.SysRevID)
                .IsFixedLength();
        }
    }
}
