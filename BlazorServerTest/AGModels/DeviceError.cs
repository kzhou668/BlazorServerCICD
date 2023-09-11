using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("DeviceError", Schema = "MSPWIP")]
    public partial class DeviceError
    {
        [Key]
        [Column("DeviceErrorID")]
        public int DeviceErrorId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string SerialNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string? ErrorCode { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Error { get; set; }
    }
}
