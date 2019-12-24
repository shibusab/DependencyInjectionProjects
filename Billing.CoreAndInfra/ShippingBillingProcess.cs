using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public class ShippingBillingProcess
    {
        private readonly IBillingCommandRepository billingCommandRepository;
        public ShippingBillingProcess(IBillingCommandRepository billingCommandRepository)
        {
            this.billingCommandRepository = billingCommandRepository;
        }

        public void PostBill(List<ShippingBill> shippingBills)
        {
            billingCommandRepository.Post(shippingBills);
        }

    }
}
