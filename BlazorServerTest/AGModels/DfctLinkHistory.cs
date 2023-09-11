using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Keyless]
    [Table("DfctLinkHistory", Schema = "MSPWIP")]
    public partial class DfctLinkHistory
    {
        public int HistoryId { get; set; }
        public Guid Version { get; set; }
        public int DfctSpecId { get; set; }
        public int DfctId { get; set; }
    }
}
