﻿using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
