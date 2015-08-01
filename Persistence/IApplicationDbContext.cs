using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Products;

namespace Persistence
{
    public interface IApplicationDbContext
    {
        Database Database { get; }
        IDbSet<ProductStore> Products { get; set; }
        int SaveChanges();
        DbSet<T> Set<T>() where T : class;
    }
}
