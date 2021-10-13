using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTaken;

namespace TDDTakenTest
{
    [TestClass]
    public class VeilingTest
    {
        [TestMethod]
        public void HoogsteBodIsNulIndienErGeenBodGedaanIs()
        {
            var veiling = new Veiling();
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }

        [TestMethod]
        public void HoogsteBodIsEersteBedragNaEersteBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(2000m);
            Assert.AreEqual(2000m, veiling.HoogsteBod);
        }

        [TestMethod]
        public void HoogsteBodAlsMeerdereBiedingenZijnGedaanIsHoogsteBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(1000m);
            veiling.DoeBod(2000m);
            veiling.DoeBod(1500m);
            Assert.AreEqual(2000m, veiling.HoogsteBod);
        }
    }
}
