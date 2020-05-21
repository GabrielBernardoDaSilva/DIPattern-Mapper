using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependecy_Injection.Entities.Interface;

namespace Dependecy_Injection.Service
{
    public abstract class AppBase<T> : IAppBase<T> where T : class
    {
        public List<T> list;

        public AppBase(List<T> t)
        {
            list = t;
        }


        public virtual void Add(T t)
        {
            list.Add(t);
        }
        public void Remove(T t)
        {
            list.Remove(t);
        }
        public IEnumerable<T> GetAll()
        {
            
            return list;
        }
        public virtual T GetByID(int id)
        {

            throw new NotImplementedException();

            
        }

    }
}
