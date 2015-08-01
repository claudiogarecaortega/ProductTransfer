using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Products;
using Persistence.Daos.Interfaces;
using Persistence.UnitOfWork;
using Utils;

namespace Persistence.Daos
{
    public class ProductDao : Dao<ProductStore>, IProductDao
    {
        public ProductDao(IUnitOfWorkHelper unitOfWorkHelper, IActivatorWrapper activator) : base(unitOfWorkHelper, activator)
        {
        }
    }
}
