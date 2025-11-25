// var numbers = new MyList<int>(5);
// var names = new MyList<string>(5);
// var beers = new MyList<Beer>(3);

// numbers.Add(1);
// numbers.Add(2);
// numbers.Add(3);
// numbers.Add(4);
// numbers.Add(5);

// Console.WriteLine(numbers.GetContent());

// names.Add("Alice");
// names.Add("Bob");
// names.Add("Charlie");
// names.Add("David");
// names.Add("Eve");

// Console.WriteLine(names.GetContent());

// beers.Add(new Beer { Name = "Lager", Price = 3.5m });
// beers.Add(new Beer { Name = "IPA", Price = 4.0m });
// beers.Add(new Beer { Name = "Stout", Price = 4.5m });

// Console.WriteLine(beers.GetContent());


// public class MyList<T>
// {
//   private List<T> _list;
//   private int _limit;

//   public MyList(int limit)
//   {
//     _limit = limit;
//     _list = [];
//   }

//   public void Add(T item)
//   {

//     if (_list.Count >= _limit)
//     {
//       throw new InvalidOperationException("List limit reached.");
//     }

//     _list.Add(item);

//   }

//   public string GetContent()
//   {
//     string content = string.Empty;
//     foreach (var item in _list)
//     {
//       content += item + " ";
//     }

//     return content;
//   }

// }

// public class Beer
// {
//   public string Name { get; set; }
//   public decimal Price { get; set; }

//   public override string ToString()
//   {
//     return $"{Name} (${Price})";
//   }
// }