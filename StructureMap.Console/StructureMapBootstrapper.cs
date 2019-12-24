using Billing.CoreAndInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Console
{
    class StructureMapBootstrapper
    {
        public static IContainer Init()
        {
            return new Container( _ =>
                {
                    _.For<IEmailProvider>().Use<TextEmailProvider>();
                    _.For<IBillingQueryRepository>().Use<BillingQueryRepository>();
                    _.For<IBillingCommandRepository>().Use<UpsBillingCommandRepository>().Named("UPS");
                    _.For<IBillingCommandRepository>().Use<FedExBillingCommandRepository>().Named("FEDEX");
                }
                );
        }
    }
}