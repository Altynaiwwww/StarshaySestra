
using StarshaySestra.Common;
using StarshaySestra.Interfaces;
using StarshaySestra.StarshaySestraDAL;
using StarshaySestra.StarshaySestraDAL.Entity;
using Telegram.Bot.Types;
using Telegram.Bots.Types;

namespace StarshaySestra.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;


        public Repository(ApplicationContext context)
        {
            _context = context;
        }

      



    }
}


