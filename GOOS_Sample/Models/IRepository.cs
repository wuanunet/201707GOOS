using System;
using GOOS_Sample.Models.DataModels;

namespace GOOS_Sample.Models
{
    public interface IRepository<T>
    {
        void Save(Budget budget);

        T Read(Func<T, bool> predicate);
    }
}