using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal; // Product Manager newlendiinde bana bir tane IproductDal referansı ver demek.

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetAll()
        {
            //İş Kodları yazılır
            return _productDal.GetAll();
        }
    }
}
