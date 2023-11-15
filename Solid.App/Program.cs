// See https://aka.ms/new-console-template for more information

using Solid.App.OCP;

Console.WriteLine("Hello, World!");

var salaryType = SalaryType.LowType;




SalaryCalculator salaryCalculator = new SalaryCalculator();


switch (salaryType)
{
    case SalaryType.LowType:
        Console.WriteLine(salaryCalculator.CalculateGood(1000, new LowLevelSalaryCalculate()));
        break;
    case SalaryType.MiddleType:
        Console.WriteLine(salaryCalculator.CalculateGood(1000, new MiddleLevelSalaryCalculate()));
        break;
    case SalaryType.HighType:
        Console.WriteLine(salaryCalculator.CalculateGood(1000, new HighLevelSalaryCalculate()));
        break;
}






