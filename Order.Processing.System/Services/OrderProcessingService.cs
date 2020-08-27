using Order.Processing.System.Interfaces.Service;
using Order.Processing.System.Models;
using Order.Processing.System.Models.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services
{
    public class OrderProcessingService
    {
        public OrderProcessingService()
        {
        }

        public void ProcessPayment()
        {
            var requestOrderObj = GetRequestOrder(Enums.AccountProductCategory.ELearning,true);
            var orderProcessorService = new RequestOrderBuilder()
                                        .WithProductCategory(Enums.AccountProductCategory.ELearning)
                                        .WithAdditionalSevice()
                                        .Build();
            orderProcessorService.ProcessOrder(requestOrderObj.Details);
        }
        private static RequestOrder GetRequestOrder(Enums.AccountProductCategory accountProductCategory,bool isAidProvided)
        {
            var orderDetail = new OrderDetail();
            orderDetail.Id = 1001;

            switch (accountProductCategory)
            {
                case Enums.AccountProductCategory.PhysicalProduct:
                    orderDetail.ProductCategory = "Physical Product";
                    orderDetail.SlipHolderName = "Shipping Department/Royal Department";
                    orderDetail.Type = "Book";
                    break;
                case Enums.AccountProductCategory.MemberShip:
                    orderDetail.ProductCategory = "MemberShip";
                    orderDetail.SlipHolderName = "Account";
                    orderDetail.Type = "Activation/Upgradation";
                    break;
                case Enums.AccountProductCategory.ELearning:
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
