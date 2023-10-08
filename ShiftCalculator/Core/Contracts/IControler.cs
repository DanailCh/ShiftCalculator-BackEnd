using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCalculator.Contracts
{
    internal interface IControler
    {
        string GetMonthlyWorkHours(string employee, string month);
    }
}
