using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public class ShippingBill
    {
        public string BillNo { get; set; }
        public string BillingBatch { get; set; }
        public string CarrierCode { get; set; }
        public string TrackingNo { get; set; }
        public double Cost { get; set; }

        public string BucketId { get; set; }

    }
}
