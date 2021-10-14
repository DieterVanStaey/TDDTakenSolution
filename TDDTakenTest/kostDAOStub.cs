using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDTaken;

namespace TDDTakenTest
{
    public class kostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 170m;
        }
    }
}
