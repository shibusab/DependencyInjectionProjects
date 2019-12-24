using Billing.CoreAndInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectInjection
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IEmailProvider>().To<TextEmailProvider>();
            Bind<IBillingCommandRepository>().To<UpsBillingCommandRepository>().Named("UPS");
            Bind<IBillingCommandRepository>().To<FedExBillingCommandRepository>().Named("FEDEX");

        }
    }
}
