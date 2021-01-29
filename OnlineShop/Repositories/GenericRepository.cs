using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
    public class GenericRepository
    {
        private readonly Models.AppContext _context;

        public GenericRepository(Models.AppContext context)
        {
            _context = context;
        }

        //public List<T> GetAll()
        //{
        //    _context.Set<T>().ToList();
        //}

        //public List<T> Get(int id)
        //{
        //    _context.Set<T>().Find(id);
        //}
    }
}
