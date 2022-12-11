using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint (generic kısıtlama.)
    // t:class : referans tip olabilir demek.
    // t:class,IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.(Category,Customer,Product)
    //new() : new'lenebilir olmalı.(IEntity kullanılamaz hale geldi.Çünkü newlenemez.)
    public interface IEntityRepository<T> where T:class,IEntity,new()                //generic (t) (REPOSITORY YAPIMIZ)
    {
        List<T> GetAll(Expression<Func<T,bool>>filter = null); //expression filtreleyerek getirmemizi sağlar.
        T Get(Expression<Func<T, bool>> filter);               //detaya gitmek için kullanılır (hesap detaylarına gitmek)
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
