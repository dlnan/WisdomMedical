//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMHC.SLTC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_Contract
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string ContractNo { get; set; }
        public Nullable<decimal> ContractValue { get; set; }
        public string DiscountInfo { get; set; }
        public Nullable<decimal> FinalValue { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string ServiceType { get; set; }
        public string ContractForm { get; set; }
        public string CaseNature { get; set; }
        public string Description { get; set; }
        public string ContractFile { get; set; }
        public Nullable<int> ReservedOperator { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
