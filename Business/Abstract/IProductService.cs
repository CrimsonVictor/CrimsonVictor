using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); //tüm ürünleri listele.
        List<Product> GetAllByCategoryId(int id);      //CategoryID ye göre ürünleri listele.(ProductManager a gidip implement et.)
        List<Product> GetByUnitPrice(decimal min,decimal max);

        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);   //sadece product döndürüyor.

        IResult Add(Product product);   //void yerine IResult döndürüyorum.

        //10.gün 1:52:28
    }
}
