using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ResLabelSpec", Schema = "MSPWIP")]
    [Index("OrgId", "Component", Name = "unc_ResLabelSpec_OrgID_Component", IsUnique = true)]
    public partial class ResLabelSpec
    {
        public ResLabelSpec()
        {
            ResPrinters = new HashSet<ResPrinter>();
        }

        [Key]
        public int ResLabelSpecId { get; set; }
        [Column("ComponentID")]
        public int ComponentId { get; set; }
        [Column("OrgID")]
        [StringLength(3)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string Component { get; set; } = null!;
        [Column("QCQuantity")]
        public int Qcquantity { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? SubLabelFlag { get; set; }

        [InverseProperty("ResLabelSpec")]
        public virtual ICollection<ResPrinter> ResPrinters { get; set; }
    }
}
