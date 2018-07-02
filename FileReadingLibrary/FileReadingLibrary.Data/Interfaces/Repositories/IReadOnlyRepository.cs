using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data.Interfaces.Repositories
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);

        ICollection<TEntity> GetAll();
    }
}