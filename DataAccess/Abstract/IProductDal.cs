using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;


namespace DataAccess.Abstract
{
    //Artık burada hangi nesne olduğunu belirterek IEntitRepository referans verip içerideki kodları kullanabiliyoruz. 
    public interface IProductDal:IEntitRepository<Product>
    {
        List<ProductDetailDto> GetProductDetail();

    }
}
//Code Refactorin kodun iyileştirilmesi