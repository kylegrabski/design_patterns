using FactoryDesignPattern.Enums;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Implementation.Books;

public class SciFiBook : IBook
{
    public string Name { get; set; }
    
    public Genres Genre { get; set; }

    public int OrderOfBook { get; set; } = 1;
    
    public ReadingLevel ReadingLevel { get; set; }
}