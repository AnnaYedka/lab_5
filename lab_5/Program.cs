// See https://aka.ms/new-console-template for more information

using lab_5;

Firm fedex = new Firm();
fedex.RegisterClient("Stacy");
fedex.MakeOrder(100, Firm.Rate.medium);

fedex.RegisterClient("John");
fedex.MakeOrder(250, Firm.Rate.high);

Console.Write("Stacy's order sum: ");
Console.WriteLine(fedex.getClientSum("Stacy"));

Console.Write("All orders sums: ");
Console.WriteLine(fedex.getAllSums());