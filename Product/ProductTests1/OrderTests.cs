using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void OrderSumTest_3筆一組_取得每組Cost總和_6_15_24_21()
        {
            //Arrange
            var order = GetInitOrder(); 
            var target = new Order();
            var expected = new List<int> { 6, 15, 24, 21 };

            //Act
            var actual = target.OrderSum(order,"Cost",3);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void OrderSumTest_4筆一組_取得每組Revenue總和_50_66_60()
        {
            //Arrange
            var order = GetInitOrder();
            var target = new Order();
            var expected = new List<int> { 50,66,60 };

            //Act
            var actual = target.OrderSum(order, "Revenue", 4);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        private List<Item> GetInitOrder()
        {
            var order = new List<Item>()
            {
                new Item() { ID = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new Item() { ID = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new Item() { ID = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new Item() { ID = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new Item() { ID = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new Item() { ID = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new Item() { ID = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new Item() { ID = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new Item() { ID = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new Item() { ID = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new Item() { ID = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };
            return order;
        }
    }
}