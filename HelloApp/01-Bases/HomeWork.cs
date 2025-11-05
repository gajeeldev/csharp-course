partial class Program
{
  static void SalesReport()
  {
    string product = "Laptop Dell";
    int quantitySold = 5;
    double unitPrice = 5499.50;
    double totalAmount = quantitySold * unitPrice;

    Console.WriteLine($"Product: {product} \nQuantity Sold: {quantitySold} \nUnit Price: ${unitPrice} \nTotal Amount: {totalAmount:C}");

  }
}