using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Injection.Entities.Interface
{
    public interface IAppBase<T> where T:class 
    {
        void Add(T t);
        void Remove(T t);
        IEnumerable<T> GetAll();
        T GetByID(int id);

    }
}
