using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Implementation.BookCovers;

public class BiographyBookCover : IBookCover
{
    public Cover CreateCover(IBook book)
    {
        return new Cover
        {
            Art = "Portrait of George Washington",
            FontType = "Cursive font"
        };
    }
}