
var sale = new Sale(15);
var message = sale.GetInfo();
Console.WriteLine(message);

class Sale
{
  public decimal Total { get; set; }
  private decimal _some;

  public Sale(decimal total)
  {
    Total = total;
  }

  public string GetInfo()
  {
    return $"Total sale amount: {Total:C}";
  }
}