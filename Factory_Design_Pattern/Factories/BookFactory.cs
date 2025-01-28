using FactoryDesignPattern.Implementation;
using FactoryDesignPattern.Enums;
using FactoryDesignPattern.Implementation.Books;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Factories;

public class BookFactory : IBookFactory
{
    public IBook CreateBook(string name, Genres genre)
    {
        switch (genre)
        {
            case (Genres.Programming):
                return new ProgrammingBook
                {
                    Name = name,
                    Genre = genre,
                    ReadingLevel = ReadingLevel.Advanced,
                };
            case (Genres.SciFi):
                return new SciFiBook
                {
                    Name = name,
                    Genre = genre,
                    ReadingLevel = ReadingLevel.AllAges,
                };
            case (Genres.Biography):
                return new BiographyBook
                {
                    Name = name,
                    Genre = genre,
                    ReadingLevel = ReadingLevel.Intermediate,
                };
            default:
                return new Book
                {
                    Name = name,
                    Genre = genre,
                    ReadingLevel = ReadingLevel.Unknown
                };
        };
    }
}