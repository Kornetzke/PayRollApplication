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
    public class AddHourlyEmployee : AddEmployeeTransaction
    {
        private decimal hourlyRate;
        public AddHourlyEmployee(int emplid, string address, string fullName, decimal hourlyRate) : base(emplid, address, fullName)
        {
            this.hourlyRate = hourlyRate;
        }
        public override IPaymentClassification GetPaymentClassification()
        {
            return new HourlyClassification(hourlyRate);
        }

        public override IPaymentSchedule GetPaymentSchedule()
        {
            return new WeeklySchedule();
        }
    }
}
