namespace HomeworkSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // input stage
            int numChildren = 0;
            int familyBonus = 0;
            int childBonus = 0;
            float taxRate = 0;
            float taxAmount = 0;
            float netSalary = 0;

            Console.WriteLine("Please enter the employee's gross salary:");
            int grossSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the emloyee's marital status (married, single or widow):");
            string maritalStatus = Console.ReadLine();
            if (maritalStatus != "single")
            {
                Console.WriteLine("Please, enter the number of employee's children:");
                numChildren = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Does the employee have any disability? (yes/no):");
            string disability = Console.ReadLine();

            // family bonus calculation
            if (maritalStatus == "married")
            {
                familyBonus = 50;
            }

            // child bonus calculation
            if (numChildren > 0)
            {
                if (numChildren == 1)
                {
                    childBonus = 30;
                }
                else if (numChildren == 2)
                {
                    childBonus = 55;
                }
                else if (numChildren == 3)
                {
                    childBonus = 75;
                }
                else
                {
                    childBonus = 75 + (numChildren - 3) * 15;
                }
            }

            // tax calculation
            if (grossSalary <= 1000)
            {
                taxRate = 15;
            }
            else if (grossSalary < 2000)
            {
                taxRate = 20;
            }
            else if (grossSalary < 3000)
            {
                taxRate = 25;
            }
            else
            {
                taxRate = 30;
            }

            if (disability == "yes")
            {
                taxRate = taxRate * 0.5F;
            }

            //final calculations
            taxAmount = grossSalary * taxRate/100;
            netSalary = grossSalary - taxAmount;          

            // output stage
            Console.WriteLine($"The family bonus is {familyBonus} AZN.");
            Console.WriteLine($"The child bonus is {childBonus} AZN.");
            Console.WriteLine($"The tax rate is {Math.Round(taxRate, 2)}%.");
            Console.WriteLine($"The tax amount is {Math.Round(taxAmount, 2)} AZN.");
            Console.WriteLine($"The gross pay is {grossSalary} AZN.");
            Console.WriteLine($"The net pay is {Math.Round(netSalary, 2)} AZN.");
            Console.WriteLine();
            
            //money calculation
            int netSalaryI = (int)netSalary;
            
            int num200 = netSalaryI / 200;
            if (num200 >= 1)
            {
                Console.WriteLine($"You need {num200} unit(s) of 200 AZN.");
                netSalaryI = netSalaryI - num200 * 200;
            }

            int num100 = netSalaryI / 100;
            if (num100 >= 1)
            {
                Console.WriteLine($"You need {num100} unit(s) of 100 AZN.");
                netSalaryI = netSalaryI - num100 * 100;
            }

            int num50 = netSalaryI / 50;
            if (num50 >= 1)
            {
                Console.WriteLine($"You need {num50} unit(s) of 50 AZN.");
                netSalaryI = netSalaryI - num50 * 50;
            }

            int num20 = netSalaryI / 20;
            if (num20 >= 1)
            {
                Console.WriteLine($"You need {num20} unit(s) of 20 AZN.");
                netSalaryI = netSalaryI - num20 * 20;
            }

            int num10 = netSalaryI / 10;
            if (num10 >= 1)
            {
                Console.WriteLine($"You need {num10} unit(s) of 10 AZN.");
                netSalaryI = netSalaryI - num10 * 10;
            }

            int num5 = netSalaryI / 5;
            if (num5 >= 1)
            {
                Console.WriteLine($"You need {num5} unit(s) of 5 AZN.");
                netSalaryI = netSalaryI - num5 * 5;
            }

            int num1 = netSalaryI / 1;
            if (num1 >= 1)
            {
                Console.WriteLine($"You need {num1} unit(s) of 1 AZN.");
                netSalaryI = netSalaryI - num1 * 1;
            }
        }
    }
}
