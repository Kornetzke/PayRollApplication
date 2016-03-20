using Payroll.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Transactions
{
    /// <summary>
    /// This abstract class will be our Template for any Employee creation class. The Execute method will not be able to be overridden, the only thing that the subclasses can change are how the Employee's PaymentClassification and the PaymentSchedule are created for the new Employee.
    /// </summary>
    public abstract class AddEmployeeTransaction : ITransaction
    {
        protected int emplid;
        protected string address;
        protected string fullName;

        public AddEmployeeTransaction(int emplid, string address, string fullName)
        {
            this.emplid = emplid;
            this.address = address;
            this.fullName = fullName;
        }

        public void Execute()
        {
            Employee e = new Employee(emplid,address,fullName);
            e.paymentClassification = GetPaymentClassification();
            e.paymentMethod = GetPaymentMethod();
            e.paymentSchedule = GetPaymentSchedule();
            Database.AddEmployee(e);
        }

        public abstract IPaymentClassification GetPaymentClassification();
        public abstract IPaymentSchedule GetPaymentSchedule();
        /// <summary>
        /// By default the AddEmployeeTransaction will return a HoldMethod for the paymentMethod
        /// </summary>
        /// <returns></returns>
        public virtual IPaymentMethod GetPaymentMethod()
        {
            return new HoldMethod();
        }
    }
}
