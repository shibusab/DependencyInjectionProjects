using Billing.CoreAndInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Console
{
    class Program
    {
        private static IContainer container { get; set; }
        static void Main(string[] args)
        {
            try
            {
                var container = StructureMapBootstrapper.Init();

                var bills = container.GetInstance<IBillingQueryRepository>().GetShippingBills("UPS");

                var billingCommandRepository = container.GetInstance<IBillingCommandRepository>("UPS");
                var billingProcess = new ShippingBillingProcess(billingCommandRepository);
                billingProcess.PostBill(GetShippingBills());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message.ToString() + ex.StackTrace.ToString());

            }
            System.Console.ReadLine();
        }
        private static List<ShippingBill> GetShippingBills()
        {
            var bills = new List<ShippingBill>();
            bills.Add(new ShippingBill { BillNo = "1", BillingBatch = "1", BucketId = "1", CarrierCode = "UPS", Cost = 13.56, TrackingNo = "1111" });

            return bills;
        }
    }
}