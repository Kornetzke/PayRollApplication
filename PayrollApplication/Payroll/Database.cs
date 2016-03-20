using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    /// <summary>
    /// This is a temporary database for storing and recieving employees, 
    /// </summary>
    public class Database
    {
        /// <summary>
        /// This stores each Employee object with the Emplid being the dictionary Key
        /// </summary>
        private static Dictionary<int, Employee> EmployeeDatabase = new Dictionary<int, Employee>();

        public static void AddEmployee(Employee e)
        {
            EmployeeDatabase.Add(e.Emplid, e);
        }

        /// <summary>
        /// Returns the Employee with the passed emplid value, if not found, method returns null
        /// </summary>
        /// <param name="emplid"></param>
        /// <returns></returns>
        public static Employee GetEmployee(int emplid)
        {
            Employee employee = null;
            EmployeeDatabase.TryGetValue(emplid, out employee);
            return employee;
        }

        public static void ClearDatabase()
        {
            EmployeeDatabase.Clear();
        }

        internal static void DeleteEmployee(int emplid)
        {
            EmployeeDatabase.Remove(emplid);
        }
    }
}
