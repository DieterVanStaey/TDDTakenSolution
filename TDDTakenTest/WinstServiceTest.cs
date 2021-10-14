using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTaken;

namespace TDDTakenTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private WinstService winstService;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;

        [TestInitialize]
        public void Initialize()
        {
            kostDAO = new kostDAOStub();
            opbrengstDAO = new opbrengstDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void Winst_OpbrengstMinKost_Is30()
        {
            Assert.AreEqual(30m, winstService.Winst);
        }
    }
}
