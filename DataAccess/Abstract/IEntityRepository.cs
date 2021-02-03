using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint => Generik kısıtlama
    //class : referans tip
    //IEntity : Hem IEntity olabilir veya onu implemente eder bir nesne olabilir.
    //new() : new'lene bilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {        
        List<T> GelAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GelAllByCategory(int categoryId); //Yukarda GetAll ve Get'e Linq ile müdehale edince buna gerek kalmadı

    }
}
