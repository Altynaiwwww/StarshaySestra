using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshaySestra.Controllers
{
    public partial class UserControllers
    {
        [Key]
        public long IdTc { get; set; }
        public string Name { get; set; }
    }
}