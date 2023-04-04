using CSharpCourseInterfaceExercise.Entities;
using CSharpCourseInterfaceExercise.Services;
using System.Globalization;

Console.WriteLine("Enter contract data:");
Console.Write("Number: ");
int accN = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double v = double.Parse(Console.ReadLine());
Console.Write("Enter number of installments: ");
int n = int.Parse(Console.ReadLine());

Contract contract = new(accN, date, v);
ContractService contractService = new(new PaypalService());
contractService.ProcessContract(contract, n);

Console.WriteLine("Installments: ");

foreach (var installment in contract.Installments) {
    Console.WriteLine($"{installment.DueDate.ToString("dd/MM/yyyy")}" +
        $" - {installment.Amount.ToString("F2", CultureInfo.InvariantCulture)}");
}
