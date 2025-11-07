partial class Program
{
  static void DataStructures()
  {

    User pedro = new User { Name = "Pedro", Age = 30 };
    pedro.Greet();

    Point point = new Point { X = 10, Y = 20 };
    Console.WriteLine($"X: {point.X}, Y: {point.Y}");

    CellPhone cellPhone = new CellPhone("iPhone 13", 2022);
    Console.WriteLine($"Model: {cellPhone.Model}, Year: {cellPhone.Year}");

  }
}

class User
{
  public string? Name { get; set; }
  public int Age { get; set; }

  public void Greet()
  {
    Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old");
  }
}

struct Point
{
  public int X { get; set; }
  public int Y { get; set; }
}

record CellPhone(string Model, int Year);