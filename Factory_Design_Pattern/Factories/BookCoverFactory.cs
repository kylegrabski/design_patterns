using FactoryDesignPattern.Implementation;
using FactoryDesignPattern.Implementation.BookCovers;
using FactoryDesignPattern.Implementation.BookCovers;
using FactoryDesignPattern.Implementation.Books;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Factories;

public class BookCoverFactory 
{
    public static IBookCover GetCoverFactory(IBook book)
    {
        switch (book)
        {
            case (SciFiBook):
                return new SciFBookCover();
            case (BiographyBook):
                return new BiographyBookCover();
            default:
                return null;
        }
    }
}