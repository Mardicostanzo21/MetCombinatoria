using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest
    {
        [DataTestMethod]
        [DataRow(0,1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        [DataRow(50,0)]


        public void TestMethod1(int N1, int N2)
        {
            int Fattoriale;

            Fattoriale = Convert.ToInt32(equazioniLibrary.CalcoliCombinatori.Fattoriale(N1));

            Assert.AreEqual(Fattoriale, N2);
        }
    }
}
