using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_7.DAL
{
    public interface IQuestList<T> where T: class
    {
        IEnumerable<T> GetAll();
        void Create(T item);
        bool Delete(int id);
        T GetItem(int id);
    }
}
