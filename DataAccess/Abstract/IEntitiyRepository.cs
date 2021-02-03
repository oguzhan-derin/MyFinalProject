using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip
    //IEntity: IEntity ve IEntity İmplemente eden 
    //new(): new'lenebilir olacak
   public interface IEntitiyRepository<T> where T:class,IEntity,new()
    {
        //Generic Repository
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);        
    }
}
