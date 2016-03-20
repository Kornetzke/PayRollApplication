using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.PaymentClassifications
{
    public class CommissionedClassification : IPaymentClassification
    {
        public decimal Salary { get; set; }
        public decimal CommissionRate { get; set; }
        public IEnumerable<SalesReceipt> SaleReceipts { get; set; }

        public CommissionedClassification(decimal salary, decimal commissionRate)
        {
            this.Salary = salary;
            this.CommissionRate = commissionRate;
            this.SaleReceipts = new List<SalesReceipt>();
        }
    }

    public class SalesReceipt
    {

    }
}
