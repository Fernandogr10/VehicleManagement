﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Common.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<int> Add(TEntity entity);
        Task AddRange(IEnumerable<TEntity> entities);
        Task<int> Update(TEntity entity);
        Task Remove(TEntity entity);
        Task<List<TEntity>> FindAll();
        Task<TEntity> FindById(Guid id);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}