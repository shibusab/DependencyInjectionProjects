using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public interface IBillingCommandRepository
    {
        void Post(List<ShippingBill> shippingBills);
        void MoveToBucket(string bucketId, List<ShippingBill> shippingBills);
    }
}
