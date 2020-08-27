using Order.Processing.System.Models.Builders;
using Order.Processing.System.Models.Common;
using Order.Processing.System.Services;
using Order.Processing.XUnit.Data;
using Xunit;

namespace Order.Processing.System.UnitTests
{
    public class OrderPrcessorUnitTest
    {

        [Fact]
        public void IsSlipGenratedForPhyicalProduct()
        {
            var service = new SlipGenratorService();
            var requestOrder = OrderProcessingData.GetRequestOrder(Enums.AccountProductCategory.PhysicalProduct, false);
            var orderDetail = service.GenerateSlip(requestOrder.Details);
            Assert.Equal("Physical Product", orderDetail.ProductCategory);


        }
        [Fact]
        public void IsEmailSendForActication()
        {
            var service = new NotificationService();
            var isMailSend = service.Sendmail();
            Assert.True(isMailSend);
        }
        [Fact]
        public void IsEmailSendForUpgradation()
        {
            var service = new SlipGenratorService();
            var requestOrder = OrderProcessingData.GetRequestOrder(Enums.AccountProductCategory.MemberShip, false);
            var orderDetail = service.GenerateSlip(requestOrder.Details);
            Assert.Equal("MemberShip", orderDetail.ProductCategory);

            var notificationService = new NotificationService();
            var isMailSend = notificationService.Sendmail();
            Assert.True(isMailSend);

        }
        
        [Fact]
        public void IsFreeAdiAddedToPackagingSlip()
        {
            var service = new SlipGenratorService();
            var requestOrder = OrderProcessingData.GetRequestOrder(Enums.AccountProductCategory.ELearning, true);
            var orderDetail = service.GenerateSlip(requestOrder.Details);
            Assert.Equal("Videos Aid", orderDetail.Aid);

        }

        
    }
}
