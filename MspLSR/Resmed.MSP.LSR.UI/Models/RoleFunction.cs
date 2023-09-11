using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("RoleFunction", Schema = "MSP")]
    public partial class RoleFunction
    {
        [Key]
        public int RoleFunctionId { get; set; }
        public int? RoleId { get; set; }
        public int? FunctionId { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [ForeignKey(nameof(FunctionId))]
        [InverseProperty("RoleFunctions")]
        public virtual Function Function { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("RoleFunctions")]
        public virtual Role Role { get; set; }
    }
}
