using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Employee
    {
        public IPaymentMethod paymentMethod { get; set; }
        public IPaymentClassification paymentClassification { get; set; }
        public IPaymentSchedule paymentSchedule { get; set; }
        public IEnumerable<IAffiliation> affiliations { get; set; }

        public int Emplid { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }

        public Employee(int emplid, string address, string fullName)
        {
            this.Emplid = emplid;
            this.Address = address;
            this.FullName = fullName;
        }


    }
}
