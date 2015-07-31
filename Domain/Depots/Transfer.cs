using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace Domain.Depots
{
    public class Transfer
    {
        public int Id { get; set; }
        public decimal Requested { get; set; }
        public decimal Pending { get; set; }
        public decimal Delivered { get; set; }
        public DateTime DateTime { get; set; }
        public Product Product { get; set; }
        public Depot DepotFrom { get; set; }
        public Depot DepotTo { get; set; }

    }
}
