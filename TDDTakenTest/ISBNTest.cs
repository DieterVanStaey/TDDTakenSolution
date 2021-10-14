using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTaken;

namespace TDDTakenTest
{
    [TestClass]
    public class ISBNTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Het Nummer 0 Is Verkeerd
        public void New_MetNummer0_IsVerkeerd()
        {
            // Arrange
            // Act
            // Assert
            new ISBN(0);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Een Negatief Nummer Is Verkeerd
        public void New_MetEenNegatiefNummer_IsVerkeerd()
        {
            // Arrange
            // Act
            // Assert
            new ISBN(-9789027439642L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Een Nummer Met 12 Cijfers Is Verkeerd
        public void New_MetEenNummerVan12Cijfers_IsVerkeerd()
        {
            // Arrange
            // Act
            // Assert
            new ISBN(978902743964L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Een Nummer Met 14 Cijfers Is Verkeerd
        public void New_MetEenNummerVan14Cijfers_IsVerkeerd()
        {
            // Arrange
            // Act
            // Assert
            new ISBN(97890274396421L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 2
        public void New_MetEenNummerVan13CijfersMetVerkeerdControleGetal2_IsVerkeerd()
        {
            // Arrange
            // Act
            // Assert
            new ISBN(8789027439642L);
        }

        [TestMethod]
        // Een Nummer Met 13 Cijfers Met Correct ControleGetal 2
        public void New_MetEenNummerVan13CijfersMetCorrectControleGetal2_IsCorrect()
        {
            // Arrange
            // Act
            // Assert
            new ISBN(9789027439642L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 0
        public void New_MetEenNummerVan13CijfersMetVerkeerdControleGetal0_IsVerkeerd()
        {
            // Arrange
            // Act
            // Assert
            new ISBN(7789227439640L);
        }

        [TestMethod]
        // Een Nummer Met 13 Cijfers Met Correct ControleGetal 0
        public void New_MetEenNummerVan13CijfersMetCorrectControleGetal0_IsCorrect()
        {
            // Arrange
            // Act
            // Assert
            new ISBN(9789227439640L);
        }
    }
}
