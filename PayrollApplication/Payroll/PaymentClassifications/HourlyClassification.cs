using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.PaymentClassifications
{
    public class HourlyClassification : IPaymentClassification
    {
        public Decimal HourlyRate { get; set; }
        public IEnumerable<TimeCard> TimeCards { get; set; }

        public HourlyClassification(Decimal hourlyRate)
        {
            this.HourlyRate = hourlyRate;
            TimeCards = new List<TimeCard>();
        }
    }

    public class TimeCard { }
}
