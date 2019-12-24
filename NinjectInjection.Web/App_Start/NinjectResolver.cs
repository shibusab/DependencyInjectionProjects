using Billing.CoreAndInfra;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectInjection.Web.App_Start
{
    public class NinjectResolver : System.Web.Mvc.IDependencyResolver
    {
        private readonly IKernel kernel;

        public NinjectResolver()
        {
            this.kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IEmailProvider>().To<TextEmailProvider>();
            kernel.Bind<IBillingCommandRepository>().To<UpsBillingCommandRepository>().Named("UPS");
            kernel.Bind<IBillingCommandRepository>().To<FedExBillingCommandRepository>().Named("FEDEX");
            kernel.Bind<IBillingQueryRepository>().To<BillingQueryRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}