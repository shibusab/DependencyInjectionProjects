using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.CoreAndInfra
{
    public class TextEmailProvider : IEmailProvider
    {
        public void Send(Email email)
        {
            throw new NotImplementedException("Text Email Provider");
        }
    }
}
