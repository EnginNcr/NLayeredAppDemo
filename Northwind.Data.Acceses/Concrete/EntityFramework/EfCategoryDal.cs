using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Data.Acceses.Abstract;
using Northwind.Data.Acceses.Concrete.EntityFremework;
using Northwind.Entities.Concrete;

namespace Northwind.Data.Acceses.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
