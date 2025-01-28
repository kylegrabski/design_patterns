using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Implementation.BookCovers;

public class SciFBookCover : IBookCover
{
    public Cover CreateCover(IBook book)
    {
        return new Cover
        {
            Art = "A cool spaceship",
            FontType = "Large Silver Lettering"
        };
    }
}