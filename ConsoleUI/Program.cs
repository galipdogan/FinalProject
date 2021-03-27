using System;
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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40,100)) 
            {
                Console.WriteLine(product.ProductName);
            }

            
        }
    }
}
