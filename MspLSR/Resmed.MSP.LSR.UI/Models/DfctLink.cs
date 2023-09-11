using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("DfctLink", Schema = "MSPWIP")]
    public partial class DfctLink
    {
        [Key]
        public int DfctLinkId { get; set; }
        public int? DfctSpecId { get; set; }
        public int? DfctId { get; set; }

        [ForeignKey(nameof(DfctId))]
        [InverseProperty("DfctLinks")]
        public virtual Dfct Dfct { get; set; }
        [ForeignKey(nameof(DfctSpecId))]
        [InverseProperty("DfctLinks")]
        public virtual DfctSpec DfctSpec { get; set; }
    }
}
