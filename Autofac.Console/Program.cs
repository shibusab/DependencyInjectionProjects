using Billing.CoreAndInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.Console
{
    class Program
    {
        private static IContainer container { get; set; }
        /// <summary>
        /// BeginLifeTimeScope - Single
        /// -Per Session
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                container = AutoFacBootstrapper.Init();

                using (var scope = container.BeginLifetimeScope())
                {
                    var bills = scope.Resolve<IBillingQueryRepository>().GetShippingBills("UPS");
                }

                //one session
                using (var scope = container.BeginLifetimeScope("session"))
                {
                    var billingCommandRepository = scope.ResolveNamed<IBillingCommandRepository>("UPS");
                    var billingProcess = new ShippingBillingProcess(billingCommandRepository);
                    billingProcess.PostBill(GetShippingBills());
                }
            }
            catch(Exception ex)
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