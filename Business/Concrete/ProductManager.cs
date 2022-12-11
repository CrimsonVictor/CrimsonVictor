using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; //(bir iş sınıfı başka sınıfları newlemez)

        public ProductManager(IProductDal productDal)  //inject.
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //business codes
            if (product.ProductName.Length<2)
            {
                //magic strings i engellemek için messages dan verileri aldım.
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product); 


            return new SuccessResult(Messages.ProductAdded);   //implemente ettiğim için IResult döndüren metoda Result new leyebiliyorum.
        }

        public List<Product> GetAll()
        {
            //iş kodları varsa.
            //yetkisi var mı 
            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);  //filtreleme şartımızı parantez içine yazıyoruz.
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductID == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
