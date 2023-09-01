using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public interface IABMLogic<T, TId>
    {
        List<T> GetAll();

        void Insert(T t);

        void Delete(TId tid);

        void Update(T t);
        
        T Find(TId id);
    }
}
