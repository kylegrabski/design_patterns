namespace FactoryDesignPattern.Interfaces;

public interface IBookCover
{
    // @TODO change the return to be a Cover type
    public Cover CreateCover(IBook book);
}

public class Cover
{
    public string Art { get; set; }
    
    public string FontType { get; set; }
}