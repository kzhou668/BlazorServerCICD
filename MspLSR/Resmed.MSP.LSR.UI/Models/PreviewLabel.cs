using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("PreviewLabel", Schema = "MSPWIP")]
    [Index(nameof(Key), Name = "UQ_PreviewLabel_Key", IsUnique = true)]
    [Index(nameof(WorkOrderNumber), Name = "nc_FK_PreviewLabel_ToWorkOrder")]
    public partial class PreviewLabel
    {
        [Key]
        [Column("PreviewLabelID")]
        public int PreviewLabelId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [StringLength(150)]
        public string ReviewedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedOn { get; set; }
        [StringLength(150)]
        public string Instruction { get; set; }
        public Guid Key { get; set; }
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }
        [Required]
        public byte[] File { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
