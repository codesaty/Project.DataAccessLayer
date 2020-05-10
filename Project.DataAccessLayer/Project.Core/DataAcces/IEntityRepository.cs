﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Project.Core.Entities;

namespace Project.Core.DataAcces
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
