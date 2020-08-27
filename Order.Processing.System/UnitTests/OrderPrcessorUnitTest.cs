//using Order.Processing.System.Models.Builders;
//using Order.Processing.System.Models.Common;
//using Order.Processing.System.Services;
//using Xunit;

//namespace Order.Processing.System.UnitTests
//{
//    public class OrderPrcessorUnitTest
//    {

//        [Fact]
//        public void IsSlipGenratedForPhyicalProduct()
//        {
//            var service = new SlipGenratorService();
//            var requestOrder = GetRequestOrder(Enums.AccountProductCategory.PhysicalProduct, false);
//            var orderDetail = service.GenerateSlip(requestOrder.Details);
//            Assert.Equal("Physical Product", orderDetail.ProductCategory);


//        }
//        [Fact]
//        public void IsEmailSendForActication()
//        {

//        }
//        [Fact]
//        public void IsEmailSendForUpgradation()
//        {

//        }
//        [Fact]
//        public void IsDuplicatePackagingSlipGenrated()
//        {

//        }

//        [Fact]
//        public void IsFreeAdiAddedToPackagingSlip()
//        {


//        }

//        private static RequestOrder GetRequestOrder(Enums.AccountProductCategory accountProductCategory, bool isAidProvided)
//        {
//            var orderDetail = new OrderDetail();
//            orderDetail.Id = 1001;

//            switch (accountProductCategory)
//            {
//                case Enums.AccountProductCategory.PhysicalProduct:
//                    orderDetail.ProductCategory = "Physical Product";
//                    orderDetail.SlipHolderName = "Shipping Department/Royal Department";
//                    orderDetail.Type = "Book";
//                    break;
//                case Enums.AccountProductCategory.MemberShip:
//                    orderDetail.ProductCategory = "MemberShip";
//                    orderDetail.SlipHolderName = "Account";
//                    orderDetail.Type = "Activation/Upgradation";
//                    break;
//                case Enums.AccountProductCategory.ELearning:
//                    orderDetail.ProductCategory = "ELearning";
//                    orderDetail.SlipHolderName = "Learning";
//                    orderDetail.Type = "Activation/Upgradation";
//                    orderDetail.Aid = isAidProvided ? "Videos Aid" : string.Empty;
//                    break;
//                default:
//                    break;
//            }

//            return new RequestOrder()
//            {
//                Details = orderDetail
//            };
//        }
//    }
//}
