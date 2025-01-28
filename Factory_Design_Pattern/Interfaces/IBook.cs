using FactoryDesignPattern.Enums;

namespace FactoryDesignPattern.Interfaces;

public interface IBook
{
    public string Name { get; set; }
    public Genres Genre { get; set; }
    public int OrderOfBook { get; set; }
    public ReadingLevel ReadingLevel { get; set; }
}