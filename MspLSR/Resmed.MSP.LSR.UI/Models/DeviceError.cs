using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("DeviceError", Schema = "MSPWIP")]
    public partial class DeviceError
    {
        [Key]
        [Column("DeviceErrorID")]
        public int DeviceErrorId { get; set; }
        [Required]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [StringLength(30)]
        public string ErrorCode { get; set; }
        [StringLength(500)]
        public string Error { get; set; }
    }
}
