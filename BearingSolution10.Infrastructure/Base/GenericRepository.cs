﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Interfaces;

namespace BearingSolution10.Infrastructure.Base
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
            where TEntity : class
            where TContext : DbContext
    {
        protected readonly TContext Context;

        protected GenericRepository(TContext context)
        {
            this.Context = context;
        }
        public void Add(TEntity model)
        {
            Context.Set<TEntity>().Add(model);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public bool HasChanges()
        {
            return Context.ChangeTracker.HasChanges();
        }

        public void Remove(TEntity model)
        {
            Context.Set<TEntity>().Remove(model);
        }

        public async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}