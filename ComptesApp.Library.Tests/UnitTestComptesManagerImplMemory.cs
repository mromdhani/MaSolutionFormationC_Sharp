using System;

using System.Collections.Generic;
using ComptesApp.Library.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ODDO.Domain;

namespace ComptesApp.Library.Tests
{
    [TestClass]
    public class UnitTestComptesManagerImplMemory
    {

        [TestMethod()]
        public void FindByIdTest()
        {
            // ARRANGE
            var underTest = new ComptesManagerImpl_Memory();
            var expected = new Compte { Numero = "C1000", Proprietaire = "Zakaria", Solde = 1000M };
            var id = "C1000";
            // ACT
            var actual = underTest.FindById(id);

            //foreach (var item in actual)
            //{
            //    Console.WriteLine(item.Proprietaire);
            //}


            // ASSERT
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void OuvrirCompteTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TestFindAll()
        {
            // ARRANGE
            var underTest = new ComptesManagerImpl_Memory();
            var expected = 3;  // Number of existings accounts

            // ACT
            var actual = underTest.FindAll();

            //foreach (var item in actual)
            //{
            //    Console.WriteLine(item.Proprietaire);
            //}
                    

            // ASSERT
            Assert.AreEqual(expected, ((IList<Compte>)actual).Count);
        }
    }
}
