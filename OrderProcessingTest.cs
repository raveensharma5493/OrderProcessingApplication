using Moq;
using System;
using Xunit;
using FactoryOrder;
using OrderInterfaces;

namespace OrderProcessingTest
{
    public class OrderProcessingTest
    {
        [Fact]
        public void Order_Processing_Test_With_PhyicalOrder_Type()
        {
            string inputType = "PhysicalOrder";
            string actualResult = FactoryClass.Create(inputType).ProcessOrder();
            Assert.Equal("packing slip generated", actualResult);
        }
        [Fact]
        public void Order_Processing_Test_With_Email_Type()
        {
            string inputType = "Email";
            string actualResult = FactoryClass.Create(inputType).ProcessOrder();
            Assert.Equal("Email has been send to customer", actualResult);
        }
        [Fact]
        public void Order_Processing_Test_With_Activate_Membership_Type()
        {
            string inputType = "Membership";
            string actualResult = FactoryClass.Create(inputType).ProcessOrder();
            Assert.Equal("Membership Activated", actualResult);
        }
        //similar way using Moq framework we can mock external dependency like DB calls,logging,API calls
        //adding one commented code for mocking external API and Fake mocking
        [Fact]
        public void Mock_DBCalls_Logging_APICalls_using_Fake_Mocking_using_Interfaces()
        {
            //Adding below for reference of mocking external dependency..but code will only work with decoupled system

            //string inputType = "PhysicalOrder";
            //Mock<IOrderProcessing> mockRepository = new Mock<IOrderProcessing>();
            //mockRepository.Setup(x => x.ProcessOrder()).Returns(true);
            //can inject mock object using constructor     
            //DBManager ob = new DBManager(mockRepository.Object);
            //var result=FactoryClass.Create(inputType);
            //Assert.Equal(10, result.count());

        }
    }
}
