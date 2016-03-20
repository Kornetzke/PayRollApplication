using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Transactions;
using Payroll.PaymentClassifications;
using Payroll.PaymentMethods;
using Payroll.PaymentSchedules;

namespace Payroll.Tests
{
    [TestClass]
    public class DeleteEmployeeTest
    {
        [TestInitialize]
        public void Init()
        {
            Database.ClearDatabase();
        }
        [TestMethod]
        public void DeleteEmployee()
        {
            int emplid = 1;
            string address = "1st Street";
            string fullName = "Bob";
            Employee e = new Employee(emplid, address, fullName);
            Database.AddEmployee(e);

            ITransaction t = new DeleteEmployeeTransaction(emplid);
            t.Execute();

            Employee actual = Database.GetEmployee(emplid+1);

            Assert.IsNull(actual);

        }
    }
}
