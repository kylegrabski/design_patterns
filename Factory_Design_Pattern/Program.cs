using FactoryDesignPattern.Enums;
using FactoryDesignPattern.Factories;
using FactoryDesignPattern.Implementation.Books;
using Sharprompt;

var yesOrNo = new Dictionary<string, bool>()
{
    {"Yes", true},
    {"No", false},
};

var isFactory = Prompt.Select("Factory? ", yesOrNo.Keys.ToArray());

if (yesOrNo[isFactory])
{
    var BookFactory = new BookFactory();
    var programmingBook = BookFactory.CreateBook("Structure and Interpretation of Computer Programs", Genres.Programming);
    var scifiBook = BookFactory.CreateBook("Enders Game", Genres.SciFi);

    Console.WriteLine("Name of book?");
    var userBookName = Console.ReadLine() ?? "Unknown";

    Console.WriteLine("Genre??");
    var userBookGenre = Console.ReadLine();

    Enum.TryParse(userBookGenre, true, out Genres selectedGenre);

    var userBook = BookFactory.CreateBook(userBookName, selectedGenre);

    if ((userBook.Genre & Genres.ThrillingSciFi) > 0)
    {
        Console.WriteLine("Could this be a Thriller SciFi book?");
    }

    Console.WriteLine($"Book Name: {userBook.Name}");
    Console.WriteLine($"Book Genre: {userBook.Genre}");
    Console.WriteLine($"Reading Level: {userBook.ReadingLevel}");
    Console.WriteLine($"Type of Book: {userBook.GetType()}");

    var bookCoverFactory = BookCoverFactory.GetCoverFactory(userBook);

    if (bookCoverFactory != null)
    {
        var ourCover = bookCoverFactory.CreateCover(userBook);
        Console.WriteLine(ourCover.Art);
        Console.WriteLine(ourCover.FontType);
    }

    return;
}

// Prototype
Console.WriteLine("Name of prototype book?");
var protoUserBookName = Console.ReadLine() ?? "Unknown";

Console.WriteLine("Prototype Genre??");
var protoUserBookGenre = Console.ReadLine();

Enum.TryParse(protoUserBookGenre, true, out Genres protoSelectedGenre);

var pb1 = new PBook
{
    Name = protoUserBookName,
    Genre = protoSelectedGenre,
    ReadingLevel = ReadingLevel.Unknown
};

Console.WriteLine("\nOur Prototype book!");
Console.WriteLine($"Book Name: {pb1.Name}");
Console.WriteLine($"Book Genre: {pb1.Genre}");
Console.WriteLine($"Reading Level: {pb1.ReadingLevel}");
Console.WriteLine($"Book Order: {pb1.OrderOfBook}");
Console.WriteLine($"Type of Book: {pb1.GetType()}");

var cloneBook = Prompt.Select("Clone? ", yesOrNo.Keys.ToArray());

if (yesOrNo[cloneBook])
{
    Console.WriteLine("\nCLONE!");
    if (pb1.Clone() is PBook pb2)
    {
        Console.WriteLine("Book Order: ");
        var orderOfBook = Console.ReadLine() ?? "0";
        pb2.OrderOfBook = int.Parse(orderOfBook);
        
        Console.WriteLine("Reading Level:");
        var readingLevel = Console.ReadLine();
        Enum.TryParse(readingLevel, true, out ReadingLevel cloneSelectedReadingLevel);
        pb2.ReadingLevel = cloneSelectedReadingLevel;
        
        Console.WriteLine("\nOur Cloned book!");
        Console.WriteLine($"Book Name: {pb2.Name}");
        Console.WriteLine($"Book Genre: {pb2.Genre}");
        Console.WriteLine($"Reading Level: {pb2.ReadingLevel}");
        Console.WriteLine($"Book Order: {pb2.OrderOfBook}");
        Console.WriteLine($"Type of Book: {pb2.GetType()}");
    }

}


