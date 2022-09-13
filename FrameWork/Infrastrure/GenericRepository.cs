using FrameWork.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Infrastrure
{
    public class GenericRepository<TKey, T> : IGenericRepository<TKey, T> where T : DomainBase<TKey>
    {
        private readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> AllT()
        {
            return _context.Set<T>().ToList();
        }

        public bool CreateT(T entity)
        {
            try
            {
                _context.Add<T>(entity);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public T GetT(TKey entityid)
        {
            return _context.Find<T>(entityid);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
