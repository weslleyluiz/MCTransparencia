using System.Collections.Generic;

namespace MCTransparencia.Models.Repository
{
    public interface IDataRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T e);
        void Update(T db, T e);
        void Delete(T e);
    }
}
