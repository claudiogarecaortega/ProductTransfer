using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Depots;

namespace Domain.Products
{
    public class ProductStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MeasureUnit { get; set; }
        public string Codigo { get; set; }
        public virtual IList<Transfer> Transfers { get; set; }
    }
}
