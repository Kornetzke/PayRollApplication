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

        public static Employee GetEmployee(int emplid)
        {
            return EmployeeDatabase[emplid];
        }
    }
}
