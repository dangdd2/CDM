using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class FoldersRel
    {
        public string Id { get; set; }
        public string FolderId { get; set; }
        public string PolymorphicModule { get; set; }
        public string PolymorphicId { get; set; }
        public short? Deleted { get; set; }
    }
}
