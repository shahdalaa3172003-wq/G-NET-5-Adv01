using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedc_01
{
   public interface IRepo<T>


    {
        void add(T item);
        void delete(T item);
        void update (T item);
        T GetById(int id);


    }
}
