partial class Program
{
  static void NumericTypes()
  {
    int intergerNumber = 42;
    double doubleNumber = 3.1416d;
    float floatNumber = 274f;
    long longNumber = 300_200_100L;
    decimal monetaryNumber = 42.50m;

    Console.WriteLine($"Integer: {intergerNumber}, Double: {doubleNumber}, Float: {floatNumber}, Long: {longNumber}, Decimal: {monetaryNumber}");

  }
}