using StarshaySestra.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshaySestra.StarshaySestraDAL.Entity
{
    public  class User:BaseEntity
    {
        public  string UserNickname { get; set; }
       public int UserId { get; set; }  
    }
}
