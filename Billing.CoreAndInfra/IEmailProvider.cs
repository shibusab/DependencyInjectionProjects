using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public interface IEmailProvider
    {
        void Send(Email email);
    }
}
