using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public class FedExBillingCommandRepository : IBillingCommandRepository
    {
        private readonly IEmailProvider emailProvider;
        public FedExBillingCommandRepository(IEmailProvider emailProvider)
        {
            this.emailProvider = emailProvider;
        }
        public void MoveToBucket(string bucketId, List<ShippingBill> shippingBills)
        {
            throw new NotImplementedException("FedEx");
        }

        public void Post(List<ShippingBill> shippingBills)
        {
            throw new NotImplementedException("FedEx");
        }
    }
}
