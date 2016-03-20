using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Transactions;
using Payroll.PaymentClassifications;
using Payroll.PaymentMethods;
using Payroll.PaymentSchedules;

namespace Payroll.Tests
{
    [TestClass]
    public class AddEmployeeTest
    {

        [TestInitialize]
        public void Init()
        {
            Database.ClearDatabase();
        }

        [TestMethod]
        public void AddSalaryEmployee()
        {
            int emplid = 1;
            string address = "1st street";
            string fullName = "Kyle";
            decimal salary = 10.0m;
            AddEmployeeTransaction t = new AddSalariedEmployee(emplid,address,fullName,salary);
            t.Execute();

            Employee e = Database.GetEmployee(emplid);
            Assert.AreEqual(emplid, e.Emplid);
            Assert.AreEqual(address, e.Address);
            Assert.AreEqual(fullName, e.FullName);

            CheckEmployeePaymentTypes(typeof(SalariedClassification), typeof(HoldMethod), typeof(MonthlySchedule), e);

            SalariedClassification sc = e.paymentClassification as SalariedClassification;
            Assert.AreEqual(salary, sc.Salary);
        }

        [TestMethod]
        public void AddHourlyEmployee()
        {
            int emplid = 2;
            string address = "2nd street";
            string fullName = "Kyle Kornetzke";
            decimal hourlyRate = 10.0m;
            AddEmployeeTransaction t = new AddHourlyEmployee(emplid, address, fullName, hourlyRate);
            t.Execute();

            Employee e = Database.GetEmployee(emplid);
            Assert.AreEqual(emplid, e.Emplid);
            Assert.AreEqual(address, e.Address);
            Assert.AreEqual(fullName, e.FullName);
            
            CheckEmployeePaymentTypes(typeof(HourlyClassification), typeof(HoldMethod), typeof(WeeklySchedule), e);

            HourlyClassification h = e.paymentClassification as HourlyClassification;
            Assert.AreEqual(hourlyRate, h.HourlyRate);
        }
        [TestMethod]
        public void AddCommissionEmployee()
        {
            int emplid = 3;
            string address = "3rd street";
            string fullName = "John";
            decimal salary = 100.0m;
            decimal commissionRate = .15m;

            AddEmployeeTransaction t = new AddCommissionedEmployee(emplid, address, fullName, salary, commissionRate);
            t.Execute();

            Employee e = Database.GetEmployee(emplid);
            Assert.AreEqual(emplid, e.Emplid);
            Assert.AreEqual(address, e.Address);
            Assert.AreEqual(fullName, e.FullName);

            CheckEmployeePaymentTypes(typeof(CommissionedClassification), typeof(HoldMethod), typeof(BiweeklySchedule), e);
            CommissionedClassification cc = e.paymentClassification as CommissionedClassification;

            Assert.AreEqual(salary, cc.Salary);
            Assert.AreEqual(commissionRate, cc.CommissionRate);

        }

        private void CheckEmployeePaymentTypes(Type classification, Type method, Type schedule, Employee employee)
        {
            Assert.IsInstanceOfType(employee.paymentClassification, classification);
            Assert.IsInstanceOfType(employee.paymentMethod, method);
            Assert.IsInstanceOfType(employee.paymentSchedule, schedule);
        }
    }
}
