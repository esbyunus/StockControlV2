using StockControlV2DL;
using StockControlV2EL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlV2BL
{
    public class MotherBoardManager : BaseManager<MotherBoard>
    {
        public MotherBoardManager(ApplicationDbContext context) : base(context)
        {
        }
    }
}
