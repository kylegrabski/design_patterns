using FactoryDesignPattern.Enums;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Implementation.Books;

public class BiographyBook : IBook
{
    public string Name { get; set; }
    public Genres Genre { get; set; }
    public int OrderOfBook { get; set; } = 4;
    public ReadingLevel ReadingLevel { get; set; }
}