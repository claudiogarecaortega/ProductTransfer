using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Products;

namespace Persistence
{
    public class ApplicationDbContext:DbContext,IApplicationDbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
        public IDbSet<ProductStore> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null) throw new ArgumentNullException("modelBuilder");

            base.OnModelCreating(modelBuilder);
        }
    }

    }
