using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Prospect_in_Hospitality
{
    class ProspectInHospitality
    {
        static void Main(string[] args)
        {
            //input
            long builders = long.Parse(Console.ReadLine());
            long receptionists = long.Parse(Console.ReadLine());
            long chambermaids = long.Parse(Console.ReadLine());
            long technitians = long.Parse(Console.ReadLine());
            long otherStaffMembers = long.Parse(Console.ReadLine());
            decimal NikiSalary = decimal.Parse(Console.ReadLine());
            decimal currencyRate = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            
            //calculations
            decimal NikiSalaryLeva = NikiSalary * currencyRate;

            decimal totalBudgetNeeded = builders * 1500.04m + receptionists * 2102.10m + 
                            chambermaids * 1465.46m + technitians * 2053.33m +          otherStaffMembers*3010.98m + NikiSalaryLeva + mySalary;

            decimal moneyLeft = budget - totalBudgetNeeded;
            //output
            Console.WriteLine("The amount is: {0:F2} lv.",totalBudgetNeeded);

            if (totalBudgetNeeded <= budget)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.",moneyLeft);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.",totalBudgetNeeded-budget);
            }
        }
    }
}
