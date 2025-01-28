using FactoryDesignPattern.Enums;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Implementation.Books;

public class ProgrammingBook : IBook
{
    public string Name { get; set; }
    
    public Genres Genre { get; set; }
    public int OrderOfBook { get; set; } = 2;
    
    public ReadingLevel ReadingLevel { get; set; }
}