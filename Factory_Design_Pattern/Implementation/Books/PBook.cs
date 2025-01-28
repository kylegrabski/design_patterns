using FactoryDesignPattern.Enums;
using FactoryDesignPattern.Prototypes;

namespace FactoryDesignPattern.Implementation.Books;

public class PBook : BookPrototype
{
    public string Name { get; set; }
    public Genres Genre { get; set; }
    public int OrderOfBook { get; set; } = 99;
    public ReadingLevel ReadingLevel { get; set; }

    public override BookPrototype? Clone()
    {
        return MemberwiseClone() as BookPrototype;
    }
}