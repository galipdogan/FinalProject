using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramerwork;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] // İsteği yaparken nasıl ulaşılacak
    [ApiController] //Attribute  bu class controller classıdır
    public class ProductsController : ControllerBase
    {
        //Loosely coupled -gevşek bağlılık-bağımlılık var ama soyuta bağlı
        //naming convention -araştır...
        //IproductService injection yapıldı
        /*IoC Container - Inversion of Control -Bellekteki bir alan ve bununla biz buraya bir adet new(EfProductDal,ProductManager... vs)leyerek referans ekliyoruz*/

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain -bağımlılık zinrici
           
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}
