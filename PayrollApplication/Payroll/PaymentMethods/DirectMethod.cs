using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.PaymentMethods
{
    public class DirectMethod : IPaymentMethod
    {
        public string Bank { get; set; }
        public int Account { get; set; }
    }
}
