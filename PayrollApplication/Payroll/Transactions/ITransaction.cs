using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Transactions
{
    /// <summary>
    /// The bulk of user input will be done through Transactions. These Transactions will change the state of Objects within the application using the Command Pattern we create new Transactions without the system knowing.
    /// </summary>
    public interface ITransaction
    {
        void Execute();
    }
}
