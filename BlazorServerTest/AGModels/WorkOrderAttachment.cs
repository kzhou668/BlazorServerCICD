using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("WorkOrderAttachment", Schema = "MSPWIP")]
    [Index("Key", Name = "UQ_WorkOrderAttachment_Key", IsUnique = true)]
    [Index("WorkOrderNumber", Name = "nc_WorkOrderAttachment_WorkOrderNumber")]
    public partial class WorkOrderAttachment
    {
        [Key]
        [Column("WorkOrderAttachmentID")]
        public int WorkOrderAttachmentId { get; set; }
        public Guid Key { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        public byte[] File { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string FileName { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string FileDescription { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string UploadedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UploadedOn { get; set; }
        public int? FileSizeInKb { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
