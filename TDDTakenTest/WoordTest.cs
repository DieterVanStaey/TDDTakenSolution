using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTaken;

namespace TDDTakenTest
{
    [TestClass]
    public class WoordTest
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}

        [TestMethod]
        // IsPalindroom_lepel_iseenpalindroom
        public void IsPalindroom_Lepel_IsEenPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }
        [TestMethod]
        // IsPalindroom_niet-palindroom_isgeenpalindroom
        public void IsPalindroom_NietPalindroom_IsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("woord").IsPalindroom());
        }
    }
}
