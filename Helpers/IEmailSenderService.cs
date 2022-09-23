using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Helpers
{
    public interface IEmailSenderService
    {
        public Task SendEmailAsync(MailRequest request);
    }
}
