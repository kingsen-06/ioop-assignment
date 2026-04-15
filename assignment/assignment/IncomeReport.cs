using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class IncomeReport
    {
        public int ModuleCount { get; set; }
        public decimal TotalEarnings { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal NetIncome { get; set; }

        public IncomeReport(int count, decimal earnings, decimal deductions, decimal net)
        {
            ModuleCount = count;
            TotalEarnings = earnings;
            TotalDeductions = deductions;
            NetIncome = net;
        }
    }
}
