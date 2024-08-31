﻿using Core.DateAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        /*
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product GetById(int id);
        List<Product> GetAllByCategory(int categoryId);
        */

        List<ProductDetailDto> GetProductDetails();
    }
}
