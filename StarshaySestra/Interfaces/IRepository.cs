using StarshaySestra.Common;
using StarshaySestra.StarshaySestraDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshaySestra.Interfaces
{
    public  interface IRepository<T> where T : BaseEntity
    {
        public T Add(T item); // C
        public List<T> AddAll(IEnumerable<T> items);
        public List<T> GetAll(); // R
        public T GetById(int id); // R
        public void Update(T item); // U
        public void Delete(T item); // D
    }


}

