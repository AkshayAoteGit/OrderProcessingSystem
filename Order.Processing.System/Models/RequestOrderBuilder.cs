using Order.Processing.System.Enums;
using Order.Processing.System.Interfaces.Service;
using Order.Processing.System.Services.Category;
using Order.Processing.System.Services.Decorator.AddOnServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Models
{
    public class RequestOrderBuilder
    {
        private AccountProductCategory _accountProductCategory;
        private bool _addAddtionalSevice = false;
        private readonly ISlipGenrator _slipGenration;
        private readonly INotificationService _notificationService;

        public RequestOrderBuilder(ISlipGenrator slipGenration, INotificationService notificationService)
        {
            _slipGenration = slipGenration;
            _notificationService = notificationService;
        }

        public IPayementPrcocessorSercvice Build()
        {
            switch (_accountProductCategory)
            {
                case AccountProductCategory.PhysicalProduct:
                    return (_addAddtionalSevice ?(IPayementPrcocessorSercvice) new PhysicalProductDecorator(_slipGenration, _notificationService) : new PhysicalProductPaymentProcessor(_slipGenration,_notificationService));
                case AccountProductCategory.MemberShip:
                    return new MembershipPaymentProcessor(_slipGenration, _notificationService);
                case AccountProductCategory.ELearning:
                    return (_addAddtionalSevice ? (IPayementPrcocessorSercvice)new ELearningDecorator(_slipGenration, _notificationService) : new ELearningPaymentProcessor(_slipGenration, _notificationService));
            }
            return null;
        }

        public RequestOrderBuilder WithProductCategory(AccountProductCategory accountProductCategory)
        {
            _accountProductCategory = accountProductCategory;
            return this;
        }

        public RequestOrderBuilder WithAdditionalSevice()
        {
            _addAddtionalSevice = true;
            return this;
        }

    }
}
