using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{    //IEntity olabilir yada IEntity implemente eden bir nesne olabilir.
    //Generic Constraint
    //class referans tip
    //new() new lenebilir olmalı çünkü IEntity new lenemez artık sadece class olabilir  
    public interface IEntityRepository<T> where T : class, IEntity,new()//sadece referanstip olabilir ve class ile class çağırabiliriz.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//Bu yapı ile tek metod ile birden farklı nesnede kullanıp ona göre nesneyi filtreleyip getirmek
        //refactoring
        T Get(Expression<Func<T, bool>> filter); //Id ye göre filtreliyor

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
