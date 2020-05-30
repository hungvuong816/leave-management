using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class //generic identity T  - so can pass any classes here to perform operations
    {
        //array of objects with T as a class
        ICollection<T> FindAll();
        T FindById(int id); 
        bool Create(T Entity); // RV - can name anything other than Entity
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
