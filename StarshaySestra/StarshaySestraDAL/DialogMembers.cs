using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshaySestra.StarshaySestraDAL
{
    public partial class DialogMembers
    {
        [Key]
        public int IdThread { get; set; }
        public long IdTc { get; set; }
        public long IdDriver { get; set; }
    }
}
