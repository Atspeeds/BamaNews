using FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Infrastrure
{
    public interface IGenericRepository<TKey,T> where T : DomainBase<TKey>
    {

        bool CreateT(T entity);
        T GetT(TKey entityid);
        IEnumerable<T> AllT();
        void Save();

    }
}
