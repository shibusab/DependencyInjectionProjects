using Billing.CoreAndInfra;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NinjectInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var kernel = new StandardKernel();
                kernel.Load(Assembly.GetExecutingAssembly());

                var billingCommandRepository = kernel.Get<IBillingCommandRepository>("UPS");
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
