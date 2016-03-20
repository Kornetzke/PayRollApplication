using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.PaymentMethods
{
    public class MailMethod : IPaymentMethod
    {
        public string Address { get; set; }
    }
}
