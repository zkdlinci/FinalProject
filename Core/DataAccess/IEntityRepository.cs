using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //class: referans tip olabilir demek
    //IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olabilir demek
    //new() : newlenebilir olmalı böylece IEntity'nin kendisi olamaz
    public interface IEntityRepository<T> where T:class , IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
