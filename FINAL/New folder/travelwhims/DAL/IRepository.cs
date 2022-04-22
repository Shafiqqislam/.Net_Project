using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T,ID>
    {
        void Add(T e);
        void Edit(T e);
        void Delete(T e);
        List<T> Get();
        T Get(ID id);
        void Delete(int id);
        //void Add(Notice data);
    }
}
