﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            //Arrange
            var customer = new Customer()
            {
                CustomerId = 1,
                Name = "testuser"
            };

            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };

            var product2 = new Product()
            {
                ProductId =2,
                Name = "pr2",
                Price = 200,
                Count = 20
            };

            var cart = new Cart(customer);
            

            var expectedResult = new List<Product>()
            {
                product1, product1, product2
            };
            //Act
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);

            var carResult = cart.GetAll();
            
            //Assert

            Assert.AreEqual(expectedResult.Count,cart.GetAll().Count);
            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], carResult[i]);
            }
        }
    }
}