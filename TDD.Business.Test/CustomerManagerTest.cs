using Business;
using DataAccess;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Business.Test
{
    [TestClass]
    public class CustomerManagerTest
    {
        Mock<ICustomerDal> _mockCustomerDal;
        List<Customer> _dbCustomers;
        [TestInitialize]
        public void Start()
        {
            _mockCustomerDal = new Mock<ICustomerDal>();
            _dbCustomers = new List<Customer>()
            {
                new Customer(){Id=1,FirstName="İlhan"},
                new Customer(){Id=2,FirstName="Rümeysa"},
                new Customer(){Id=3,FirstName="Hakan"},
                new Customer(){Id=4,FirstName="Ali"},
                new Customer(){Id=5,FirstName="Müşerref"},
            };
            _mockCustomerDal.Setup(x => x.GetAll()).Returns(_dbCustomers);
        }
        [TestMethod]
        public void GetAllCustgomer()
        {
            //Arrange
            ICustomerService serivce = new CustomerManager(_mockCustomerDal.Object);
            //Act
            List<Customer> customers = serivce.GetAll();
            //Assert
            Assert.AreEqual(5, customers.Count);

        }
        [TestMethod]
        public void FirstCharacterIsA()
        {
            ICustomerService serivce = new CustomerManager(_mockCustomerDal.Object);
            //Act
            List<Customer> customers = serivce.GetCustomerByInitial("A");
            //Assert
            Assert.AreEqual(1, customers.Count);
        }
        [TestMethod]
        public void FirstCharacterIsLowercaseA()
        {
            ICustomerService serivce = new CustomerManager(_mockCustomerDal.Object);
            //Act
            List<Customer> customers = serivce.GetCustomerByInitial("a");
            //Assert
            Assert.AreEqual(1, customers.Count);
        }

    }
}
//Müşteriler Listelenebilmelidir
//Müşteriler Baş Harflerine Göre Sayfalanabilmelidir


//Case1:5 Tüm müşteriler Listelenmelidir