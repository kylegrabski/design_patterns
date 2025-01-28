namespace FactoryDesignPattern.Enums;

[Flags]
public enum Genres
{
    Unknown = 0,
    Thriller = 1,
    SciFi = 2,
    Drama = 4,
    Biography = 8,
    Humor = 16,
    Programming = 32,
    ThrillingSciFi = Thriller | SciFi,
    FunnyBiography = Biography | Humor
}