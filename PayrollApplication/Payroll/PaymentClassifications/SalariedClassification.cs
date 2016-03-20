using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.PaymentClassifications
{
    public class SalariedClassification : IPaymentClassification
    {
        public Decimal Salary { get; set; }

        public SalariedClassification(decimal salary)
        {
            this.Salary = salary;
        }
    }
}
