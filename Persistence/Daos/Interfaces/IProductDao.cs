using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Products;

namespace Persistence.Daos.Interfaces
{
    public interface IProductDao : IDao<ProductStore>
    {
   
    }
}
