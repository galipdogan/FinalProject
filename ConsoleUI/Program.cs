using System;
using System.ComponentModel.Design;
using Business.Concrete;
using DataAccess.Concrete.EntityFramerwork;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle - Yaptığımız yazılıma yeni bir özellik ekliyorsan mevcut kodlara dokunamazsın
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetail();

            if (result.Success == true)
            {
                foreach (var product in productManager.GetProductDetail().Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
