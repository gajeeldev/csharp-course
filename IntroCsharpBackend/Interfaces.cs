
// var sale = new Sale(100);
// var beer = new Beer();

// Some(sale);
// Some(beer);

// void Some(ISave saveable)
// {
//   saveable.Save();
// }

// interface ISale
// {
//   decimal Total { get; set; }
// }

// interface ISave
// {
//   public void Save();
// }

// public class Sale : ISale, ISave
// {
//   public decimal Total { get; set; }


//   public Sale(decimal total)
//   {
//     Total = total;
//   }
//   public void Save()
//   {
//     Console.WriteLine("Guardando en BD");
//   }
// }

// public class Beer : ISave
// {
//   public void Save()
//   {
//     Console.WriteLine("Guardando en servicio");
//   }
// }