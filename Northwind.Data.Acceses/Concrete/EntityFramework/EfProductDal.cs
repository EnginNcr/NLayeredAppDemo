using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Data.Acceses.Abstract;
using Northwind.Data.Acceses.Concrete.EntityFremework;
using Northwind.Entities.Concrete;

namespace Northwind.Data.Acceses.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase  <Product,NorthwindContext>,IProductDal
    {
       
       
    }
}
