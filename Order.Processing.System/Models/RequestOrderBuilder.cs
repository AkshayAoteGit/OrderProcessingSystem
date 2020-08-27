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

        public IPayementPrcocessorSercvice Build()
        {
            switch (_accountProductCategory)
            {
                case AccountProductCategory.PhysicalProduct:
                    return (_addAddtionalSevice ?(IPayementPrcocessorSercvice) new PhysicalProductDecorator(): new PhysicalProductPaymentProcessor());
                case AccountProductCategory.MemberShip:
                    return new MembershipPaymentProcessor();
                case AccountProductCategory.ELearning:
                    return (_addAddtionalSevice ? (IPayementPrcocessorSercvice)new ELearningDecorator() : new ELearningPaymentProcessor());
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
