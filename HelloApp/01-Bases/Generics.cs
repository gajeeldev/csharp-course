partial class Program
{
  static void Generics()
  {
    string[] names = { "John", "Jane", "Bob" };
    int[] numbers = { 1, 2, 3 };

    Console.WriteLine($"Longitud del array de nombres: {GetArrayLength(names)}");
    Console.WriteLine($"Longitud del array de números: {GetArrayLength(numbers)}");

    Box<string> stringBox = new Box<string> { Content = "Hola mundo" };
    stringBox.Show();

    Box<int> intBox = new Box<int> { Content = 42 };
    intBox.Show();
  }

  static int GetArrayLength<T>(T[] array)
  {
    return array.Length;
  }
}

class Box<T>
{
  public T? Content { get; set; }

  public void Show()
  {
    Console.WriteLine($"El contenido de la caja es: {Content}");
  }
}