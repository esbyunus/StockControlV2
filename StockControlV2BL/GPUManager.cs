using StockControlV2DL;
using StockControlV2EL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlV2BL
{
    public class GPUManager : BaseManager<GPU>
    {
        public GPUManager(ApplicationDbContext context) : base(context)
        {
        }
    }
}
