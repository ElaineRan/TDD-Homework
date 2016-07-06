using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void Cost_Add_3_Item()
        {
            //arrange
            Product target = new Product();
            //用三筆計算
            int count = 3;
            var expected = new List<int> { 6, 15, 24, 21 };

            //act
            var actual = target.CostAdd(count);

            //assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Revenue_Add_4_Item()
        {
            //arrange
            Product target = new Product();
            //用四筆計算
            int count = 4;
            var expected = new List<int> { 50, 66, 60 };

            //act
            var actual = target.RevenueAdd(count);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
