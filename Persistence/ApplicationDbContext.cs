using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("DefaultConection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null) throw new ArgumentNullException("modelBuilder");

            base.OnModelCreating(modelBuilder);
        }
    }

    }
