Console.Write("Enter a day (Example: Sunday): ");
string inputDay = Console.ReadLine().Trim().ToLower();

DayType dayType;

if (inputDay == "sunday" || inputDay == "saturday" || inputDay == "monday")
{
    dayType = DayType.Weekend;
}
else
{
    dayType = DayType.Weekday;
}
Console.WriteLine("\n");
Console.WriteLine("It is: " + dayType);


//Book object
Book book1 = new Book("Web development ", "Apekshya Ban", 5000);

// object using 'with' expression
Book book2 = book1 with { title = "Advanced prgraming", price = 10000 };

Console.WriteLine("\n");
Console.WriteLine($"Title: {book1.title}");
Console.WriteLine($"Author: {book1.author}");
Console.WriteLine($"Price: {book1.price}");

// Deconstructed object
var (title2, author2, price2) = book2;

Console.WriteLine("\n");
Console.WriteLine($"Title: {title2}");
Console.WriteLine($"Author: {author2}");
Console.WriteLine($"Price: {price2}");