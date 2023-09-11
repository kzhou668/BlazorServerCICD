using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("RoleFunction", Schema = "MSP")]
    public partial class RoleFunction
    {
        [Key]
        public int RoleFunctionId { get; set; }
        public int? RoleId { get; set; }
        public int? FunctionId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        [ForeignKey("FunctionId")]
        [InverseProperty("RoleFunctions")]
        public virtual Function? Function { get; set; }
        [ForeignKey("RoleId")]
        [InverseProperty("RoleFunctions")]
        public virtual Role? Role { get; set; }
    }
}
