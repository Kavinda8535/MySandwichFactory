﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySandwitchFactory.Portal.Common;

namespace MySandwitchFactory.DataAccess
{
    //public class Repository<T> : IRepository<T> where T : class , IEntity
    //{
    //    protected DbSet<T> DbSet;

    //    public Repository(DbContext dataContext)
    //    {
    //        DbSet = dataContext.Set<T>();
    //    }

    //    #region IRepository<T> Members

    //    public void Insert(T entity)
    //    {
    //        DbSet.Add(entity);
    //    }

    //    public void Delete(T entity)
    //    {
    //        DbSet.Remove(entity);
    //    }

    //    public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
    //    {
    //        return DbSet.Where(predicate);
    //    }

    //    public IQueryable<T> GetAll()
    //    {
    //        return DbSet;
    //    }

    //    public T GetById(int id)
    //    {
    //        return DbSet.Find(id);
    //    }

    //    #endregion
    //}
}
