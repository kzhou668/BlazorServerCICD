﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ActionType", Schema = "MSPWIP")]
    [Index(nameof(ActionType1), Name = "unc_ActionType_ActionType", IsUnique = true)]
    public partial class ActionType
    {
        [Key]
        public int ActionTypeId { get; set; }
        [Required]
        [Column("ActionType")]
        [StringLength(100)]
        public string ActionType1 { get; set; }
        public int ActionPriority { get; set; }
        public bool MultiActionAllowed { get; set; }
        [Column("IsQCAction")]
        public bool IsQcaction { get; set; }
        [Column("IsTLAction")]
        public bool IsTlaction { get; set; }
    }
}
