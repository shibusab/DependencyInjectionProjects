using Billing.CoreAndInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.Console
{
    public class AutoFacBootstrapper
    {
        public static IContainer Init()
        {
            //For constructor injection, Autofac will replace the appropriate Interface
            var builder = new ContainerBuilder();

            builder.RegisterType<TextEmailProvider>()
                .As<IEmailProvider>();

            builder
                .RegisterType<BillingQueryRepository>()
                .As<IBillingQueryRepository>();
            
            builder
                .RegisterType<UpsBillingCommandRepository>()
                .Named<IBillingCommandRepository>("UPS");

            builder
                .RegisterType<FedExBillingCommandRepository>()
                .Named<IBillingCommandRepository>("FEDEX");

            return builder.Build();
        }
    }
}
