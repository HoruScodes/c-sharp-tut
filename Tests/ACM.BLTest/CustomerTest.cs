using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Security.Cryptography.X509Certificates;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]

        public void FullNameTestValdation()
        {

            //-- Arrange
            Customer customer = new Customer();

            customer.FirstName = "Rahul";
            customer.LastName = "Pipaliya";

            string expected = "Pipaliya,Rahul";


            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FirstNameEmptyTestValdation()
        {

            //-- Arrange
            Customer customer = new Customer();

            customer.LastName = "Pipaliya";

            string expected = "Pipaliya";


            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
    }
}

    


