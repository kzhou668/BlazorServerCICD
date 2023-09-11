using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("NCD", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), Name = "nc_Ncd_WorkOrderNumber")]
    public partial class Ncd
    {
        [Key]
        public int NcdId { get; set; }
        [StringLength(30)]
        public string NcdNumber { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [StringLength(20)]
        public string Status { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
