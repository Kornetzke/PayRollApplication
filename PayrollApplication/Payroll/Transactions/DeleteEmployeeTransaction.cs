using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Transactions
{
    public class DeleteEmployeeTransaction : ITransaction
    {

        private int emplid;

        public DeleteEmployeeTransaction(int emplid)
        {
            this.emplid = emplid;
        }

        public void Execute()
        {
            Database.DeleteEmployee(emplid);
        }
    }
}
