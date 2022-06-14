using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace Northwind.Data.Acceses.Concrete
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products{ get; set; }
    } 
}
