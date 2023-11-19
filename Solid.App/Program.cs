// See https://aka.ms/new-console-template for more information

using Solid.App.DIP;
using Solid.App.ISP;
using Solid.App.LSP;
using ProductRepository = Solid.App.ISP.ProductRepository;

Console.WriteLine("Hello, World!");


var productController = new ProductController(new ProductService(new ProductRepositoryFactory().GetPostgreInstance()));

productController.GetAll().ForEach(x =>
{
    Console.WriteLine($"{x.Id} {x.Name} {x.Price}");
});


//Read Client

IReadProductRepository productRepository = new ProductRepository();

#region LSP
//Phone phone = new IPhone15();

//if (phone is ITakePhoto iphone)
//{
//    iphone.TakePhoto();
//}

//phone = new Nokia3310();
//if (phone is ITakePhoto nokia)
//{
//    nokia.TakePhoto();
//}
//else
//{
//    Console.WriteLine("Nokia fotoğraf çekme özelliği yok");
//} 
#endregion
#region OCP

//var salaryType = SalaryType.LowType;
//var baseSalary = 1000;


//SalaryCalculator salaryCalculator = new SalaryCalculator();



//var SalaryCalculateDictionary = new Dictionary<SalaryType, ISalaryCalculate>
//{
//    { SalaryType.LowType, new LowLevelSalaryCalculate() },
//    { SalaryType.MiddleType, new MiddleLevelSalaryCalculate() },
//    { SalaryType.HighType, new HighLevelSalaryCalculate() }
//};

//Console.WriteLine(SalaryCalculateDictionary[salaryType].Calculate(baseSalary));




//switch (salaryType)
//{
//    case SalaryType.LowType:
//        Console.WriteLine(salaryCalculator.CalculateGood(1000, new LowLevelSalaryCalculate()));
//        break;
//    case SalaryType.MiddleType:
//        Console.WriteLine(salaryCalculator.CalculateGood(1000, new MiddleLevelSalaryCalculate()));
//        break;
//    case SalaryType.HighType:
//        Console.WriteLine(salaryCalculator.CalculateGood(1000, new HighLevelSalaryCalculate()));
//        break;
//}

#endregion





