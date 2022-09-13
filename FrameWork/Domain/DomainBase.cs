using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Domain
{
    public class DomainBase<T>
    {
        public T Id { get; private set; }
        public DateTime Creationdate { get; private set; }

        public DomainBase()
        {
            Creationdate = DateTime.Now;
        }

    }
}
