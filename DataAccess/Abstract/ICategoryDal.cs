
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntitRepository<Category>//Artık burada hangi nesne olduğunu belirterek IEntitRepository referans verip içerideki kodları kullanabiliyoruz. 
    {
                
    }
}
