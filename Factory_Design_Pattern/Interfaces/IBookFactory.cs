using FactoryDesignPattern.Enums;

namespace FactoryDesignPattern.Interfaces;

public interface IBookFactory
{
    public IBook CreateBook(string name, Genres genre);
}
