﻿namespace EntityFrameworkMVC.Models.Repositories
{
    using System.Data.Entity;
    using System.Linq;
    using EF;

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EntityFrameworkMvcDbContext context;
        private readonly DbSet<T> dbSet;

        public Repository(EntityFrameworkMvcDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T FetchById(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> Fetch()
        {
            return dbSet;
        }
    }
}