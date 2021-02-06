using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        // IEntityRepository Yaratıldıktan sonra bunları kestik
        // Amaç hem product hemde Categori için bunları tekrarlamak yerine Generic Tip üzeirnden tekrarlamayı engellemek
        //List<Category> GelAll();
        //void Add(Category category);
        //void Update(Category category);
        //void Delete(Category category);
        //List<Category> GelAllByCategory(int categoryId);

    }
}
