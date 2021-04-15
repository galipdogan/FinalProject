using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>//Artık burada hangi nesne olduğunu belirterek IEntitRepository referans verip içerideki kodları kullanabiliyoruz. 
    {
        
    }
}
