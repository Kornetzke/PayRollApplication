using Payroll.PaymentClassifications;
using Payroll.PaymentMethods;
using Payroll.PaymentSchedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Transactions
{
    public class AddSalariedEmployee : AddEmployeeTransaction
    {
        private decimal salary;
        public AddSalariedEmployee(int emplid, string address, string fullName,decimal salary) : base(emplid,address,fullName)
        {
            this.salary = salary;
        }
        public override IPaymentClassification GetPaymentClassification()
        {
            return new SalariedClassification(salary);
        }
        
        public override IPaymentSchedule GetPaymentSchedule()
        {
            return new MonthlySchedule();
        }
    }
}
