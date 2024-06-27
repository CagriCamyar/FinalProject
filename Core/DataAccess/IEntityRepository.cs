using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//Core Katmanı Diğer Katmanları Referans Almaz.!! 

namespace Core.DataAccess
{
    //generic constraint
    //class demek referans tip demek 
    //new() ==> new'lenebilir bir IEntity olmalı demek IEntity newlenemeyeceği için Entities klasöründeki Concrete bölümündeki nesneleri kullanabiliriz.
    public interface IEntityRepository<T> where T : class,  IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter); 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);        
    }
}
