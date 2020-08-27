using Order.Processing.System.Enums;
using Order.Processing.System.Models.Builders;
using Order.Processing.System.Models.Common;

namespace Order.Processing.XUnit.Data
{
    public class OrderProcessingData
    {
        public static RequestOrder GetRequestOrder(AccountProductCategory accountProductCategory, bool isAidProvided)
        {
            var orderDetail = new OrderDetail();
            orderDetail.Id = 1001;

            switch (accountProductCategory)
            {
                case AccountProductCategory.PhysicalProduct:
                    orderDetail.ProductCategory = "Physical Product";
                    orderDetail.SlipHolderName = "Shipping Department/Royal Department";
                    orderDetail.Type = "Book";
                    break;
                case AccountProductCategory.MemberShip:
                    orderDetail.ProductCategory = "MemberShip";
                    orderDetail.SlipHolderName = "Account";
                    orderDetail.Type = "Activation/Upgradation";
                    break;
                case AccountProductCategory.ELearning:
                    orderDetail.ProductCategory = "ELearning";
                    orderDetail.SlipHolderName = "Learning";
                    orderDetail.Type = "Activation/Upgradation";
                    orderDetail.Aid = isAidProvided ? "Videos Aid" : string.Empty;
                    break;
                default:
                    break;
            }

            return new RequestOrder()
            {
                Details = orderDetail
            };
        }
    }
}
