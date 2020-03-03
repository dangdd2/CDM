using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Expressions
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string LhsType { get; set; }
        public string LhsField { get; set; }
        public string LhsModule { get; set; }
        public string LhsValue { get; set; }
        public string LhsGroupType { get; set; }
        public string Operator { get; set; }
        public string RhsGroupType { get; set; }
        public string RhsType { get; set; }
        public string RhsField { get; set; }
        public string RhsModule { get; set; }
        public string RhsValue { get; set; }
        public string ParentId { get; set; }
        public string ExpType { get; set; }
        public int? ExpOrder { get; set; }
        public string ParentType { get; set; }
        public string ParentExpId { get; set; }
        public int? ParentExpSide { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
        public string Ext3 { get; set; }
    }
}
