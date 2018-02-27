using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        T GetById(int id);

        IEnumerable<T> GetAll();
    }
}
