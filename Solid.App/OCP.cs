using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCP
{
    public enum SalaryType
    {
        LowType=0,
        MiddleType=1,
        HighType=2,
        
    }

    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }

    public class LowLevelSalaryCalculate:ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MiddleLevelSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class HighLevelSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 8;
        }
    }

    public class ManagerLevelSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 16;
        }
    }


    public class ManagerDelegateSalaryCalculate
    {

       public  decimal Calculate(decimal salary)
        {
            return salary * 20;
        }
    }


    public class SalaryCalculator
    {
        //private Action<int> deger => (a) => { Console.Write(a); };
        //private Predicate<int> deger2 => (a) => { return a==5;};

        //private Func<int, int, int> deger3 => (a, b) => a + b;


        public decimal CalculateDelegate(decimal salary, Func<decimal, decimal> salaryCalculate)
        {
            return salaryCalculate(salary);
        }



        public decimal CalculateGood(decimal salary,ISalaryCalculate salaryCalculate)
        {

            return salaryCalculate.Calculate(salary);
        }





        public decimal Calculate(decimal salary, SalaryType salaryType)
        {
            decimal newSalary = 0;

            switch (salaryType)
            {
                case SalaryType.LowType:
                    newSalary = salary * 2;
                    break;
                case SalaryType.MiddleType:
                    newSalary = salary * 4;
                    break;
                case SalaryType.HighType:
                    newSalary = salary * 8;
                    break;

            }

            return newSalary;
        }




    }
}
