using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{

    public interface IProductDal:IEntityRepository<Product>
    {
        // IEntityRepository Yaratıldıktan sonra bunları kestik
        // Amaç hem product hemde Categori için bunları tekrarlamak yerine Generic Tip üzeirnden tekrarlamayı engellemek
        //List<Product> GelAll();
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);
        //List<Product> GelAllByCategory(int categoryId);

    }
}
