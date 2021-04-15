using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
   public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new() // Bu satırda kuralları koyuyoruz. sadece class
        where TContext:DbContext,new()// Burada sadece DBContext türünü yazabilirsiniz
   {
       public void Add(TEntity entity)
       {
           //IDisposabla pattern implementation of C#
           using (TContext context = new TContext())//Bu şekilde işi bitince bellekten atar
           {
               var addedEntity = context.Entry(entity);
               addedEntity.State = EntityState.Added;
               context.SaveChanges();
           }
       }

       public void Delete(TEntity entity)
       {
           using (TContext context = new TContext())//Bu şekilde işi bitince bellekten atar
           {
               var deletedEntity = context.Entry(entity);
               deletedEntity.State = EntityState.Deleted;
               context.SaveChanges();
           }
       }

       public TEntity Get(Expression<Func<TEntity, bool>> filter)
       {
           using (TContext context = new TContext())
           {
               return context.Set<TEntity>().SingleOrDefault(filter);
           }
       }

       public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
       {
           //Filtreleme yaparak listeliyoruz. Eğer filtre koşulu yoksa hepsini getir
           using (TContext context = new TContext())
           {
               return filter == null
                   ? context.Set<TEntity>().ToList()
                   : context.Set<TEntity>().Where(filter).ToList();
           }
       }

       public void Update(TEntity entity)
       {
           using (TContext context = new TContext())//Bu şekilde işi bitince bellekten atar
           {
               var updatedEntity = context.Entry(entity);
               updatedEntity.State = EntityState.Modified;
               context.SaveChanges();
           }
       }
    }
}
