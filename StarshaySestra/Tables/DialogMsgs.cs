using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshaySestra.Tables
{
    public partial class DialogMsgs
    {
        [Key]
        public long IdUnique { get; set; }
        public int IdThread { get; set; }
        public string Created { get; set; }
       
        public string Message { get; set; }
    }
}
