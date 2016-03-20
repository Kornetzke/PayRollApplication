using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.PaymentClassifications;
using Payroll.PaymentSchedules;

namespace Payroll.Transactions
{
    public class AddCommissionedEmployee : AddEmployeeTransaction
    {

        private decimal salary;
        private decimal commissionRate;

        public AddCommissionedEmployee(int emplid, string address, string fullName, decimal salary, decimal commissionRate) : base(emplid,address, fullName)
        {
            this.salary = salary;
            this.commissionRate = commissionRate;
        }

        public override IPaymentClassification GetPaymentClassification()
        {
            return new CommissionedClassification(salary, commissionRate);
        }

        public override IPaymentSchedule GetPaymentSchedule()
        {
            return new BiweeklySchedule();
        }
    }
}
