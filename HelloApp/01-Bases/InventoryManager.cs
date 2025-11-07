partial class Program
{
  static void InventoryManager()
  {
    string[] products = ["Monitor", "Mouse", "Teclado"];
    int[] stock = [10, 25, 30];
    double[] prices = [250.50, 20.50, 45.00];


    Console.WriteLine("Bienvenido al inventario de productos.");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Comprar producto");
    Console.WriteLine("2. Salir");

    int option = int.Parse(Console.ReadLine()!);

    if (option != 1 && option != 2)
    {
      Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
      return;
    }

    if (option == 2)
    {
      Console.WriteLine("Saliendo del programa.");
      return;
    }

    Console.WriteLine("Inventario de productos:");
    Console.WriteLine("-------------------");

    for (int i = 0; i < products.Length; i++)
    {
      Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: ${prices[i]}");
    }

    Console.WriteLine("\nIngrese el producto que desea comprar: ");
    string? searchedProduct = Console.ReadLine();

    Console.WriteLine("Ingrese la cantidad que desea comprar: ");
    int quantity = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < products.Length; i++)
    {
      if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
      {
        if (quantity <= stock[i])
        {
          double total = quantity * prices[i];
          Console.WriteLine($"Compra exitosa. Total a pagar: {total}");

          stock[i] -= quantity;
          Console.WriteLine($"Stock restante para el producto {products[i]} es: {stock[i]}");


        }
        else
        {
          Console.WriteLine($"No hay suficiente stock del producto {products[i]}");
        }
      }
    }


  }
}
