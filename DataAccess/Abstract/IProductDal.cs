using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>     //repository yi product için  yapılandırdın.
    {
        List<ProductDetailDto> GetProductDetails();
        
    }
}

//Code Refactoring : kodun iyileştirilmesi.