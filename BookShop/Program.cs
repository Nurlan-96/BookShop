using BookShop.Domain.Models;

Book book1 = new("The Lord of the Rings",18,2,"J.R.R. Tolkien",300);
Console.WriteLine(book1.ShowInfo());
book1.Sell(); //biri satildi, income price qeder artdi
book1.Sell(); //ikinci kitab satildi
Console.WriteLine(book1.ShowInfo());
book1.Sell(); //kitab qalmadigina gore satis bas vermir ve error message gelir 
Console.WriteLine(book1.ShowInfo());
