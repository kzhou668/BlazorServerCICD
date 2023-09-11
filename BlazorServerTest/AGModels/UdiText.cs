using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("UdiText", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", "SerialNumber", Name = "nc_UdiText_WO_Serial")]
    public partial class UdiText
    {
        [Key]
        [Column("UdiTextID")]
        public int UdiTextId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string? SerialNumber { get; set; }
        [Column("UdiText")]
        [StringLength(100)]
        [Unicode(false)]
        public string? UdiText1 { get; set; }
    }
}
