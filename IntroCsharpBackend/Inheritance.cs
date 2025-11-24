
// var sale = new SaleWithTax(15, 10);
// var message = sale.GetInfo();
// Console.WriteLine(message);


// class SaleWithTax : Sale
// {
//   public decimal TaxRate { get; set; }

//   public SaleWithTax(decimal total, decimal taxRate) : base(total)
//   {
//     TaxRate = taxRate;
//   }

//   public override string GetInfo()
//   {
//     return $"el total es {Total} y el impuesto es {TaxRate}";
//   }
//   public string GetInfo(string message)
//   {
//     return message;
//   }

// }

// class Sale
// {
//   public decimal Total { get; set; }
//   private decimal _some;

//   public Sale(decimal total)
//   {
//     Total = total;
//   }

//   public virtual string GetInfo()
//   {
//     return $"Total sale amount: {Total:C}";
//   }
// }