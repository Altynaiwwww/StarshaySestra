using StarshaySestra.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshaySestra.Tables
{
    public partial class DialogStatus : BaseEntity
    {
        [Key]
        public long TgId { get; set; }
        public int Status { get; set; }
        public long CurrentDialog { get; set; }

    }
}
