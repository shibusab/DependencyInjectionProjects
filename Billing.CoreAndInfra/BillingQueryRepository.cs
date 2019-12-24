using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public class BillingQueryRepository : IBillingQueryRepository
    {
        public List<ShippingBill> GetShippingBills(string carrierCode)
        {
            return GetShippingBills();
        }
        private List<ShippingBill> GetShippingBills()
        {
            var bills = new List<ShippingBill>();
            bills.Add(new ShippingBill { BillNo = "1", BillingBatch = "1", BucketId = "1", CarrierCode = "UPS", Cost = 13.56, TrackingNo = "1111" });
            bills.Add(new ShippingBill { BillNo = "1", BillingBatch = "1", BucketId = "1", CarrierCode = "UPS", Cost = 13.56, TrackingNo = "1111" });
            bills.Add(new ShippingBill { BillNo = "1", BillingBatch = "1", BucketId = "1", CarrierCode = "UPS", Cost = 13.56, TrackingNo = "1111" });
            bills.Add(new ShippingBill { BillNo = "1", BillingBatch = "1", BucketId = "1", CarrierCode = "UPS", Cost = 13.56, TrackingNo = "1111" });
            bills.Add(new ShippingBill { BillNo = "1", BillingBatch = "1", BucketId = "1", CarrierCode = "UPS", Cost = 13.56, TrackingNo = "1111" });
            return bills;
        }
    }
}
