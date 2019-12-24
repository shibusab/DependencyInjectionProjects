using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public interface IBillingQueryRepository
    {
        List<ShippingBill> GetShippingBills(string carrierCode);
    }
}
