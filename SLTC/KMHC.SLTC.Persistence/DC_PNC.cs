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
    
    public partial class DC_PNC
    {
        public DC_PNC()
        {
            this.DC_CheckRoomSch = new HashSet<DC_CheckRoomSch>();
        }
    
        public int PNCID { get; set; }
        public string PNCNo { get; set; }
        public string PNCName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int OrganizationID { get; set; }
        public int Status { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual ICollection<DC_CheckRoomSch> DC_CheckRoomSch { get; set; }
        public virtual ORG_Organization ORG_Organization { get; set; }
    }
}
