using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    class BankTransaction
    {
        public decimal Amont ;
        public DateTime day;
        public BankTransaction (decimal _Amont)
        {
            day = DateTime.Now;
            Amont = _Amont ;
        }
    }
}
