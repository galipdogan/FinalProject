using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramerwork
{
    public class EfOrderDal: EfEntityRepositoryBase<Order, NorthwindContext>,IOrderDal
    {
    }
}
