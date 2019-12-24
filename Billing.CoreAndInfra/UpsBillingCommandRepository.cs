using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public class UpsBillingCommandRepository : IBillingCommandRepository
    {
        private readonly IEmailProvider emailProvider;
        public UpsBillingCommandRepository(IEmailProvider emailProvider)
        {
            this.emailProvider = emailProvider;
        }
        public void MoveToBucket(string bucketId, List<ShippingBill> shippingBills)
        {
            emailProvider.Send(new Email());
            throw new NotImplementedException("UPS");
        }

        public void Post(List<ShippingBill> shippingBills)
        {
            emailProvider.Send(new Email());
            throw new NotImplementedException("UPS");
        }
    }
}
