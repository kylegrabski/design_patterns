namespace FactoryDesignPattern.Enums;

[Flags]
public enum ReadingLevel
{
    Unknown = 0,
    Preschool = 1,
    Elementary = 2,
    JuniorHigh = 4,
    HighSchool = 8,
    College = 16,
    Beginner = Preschool | Elementary,
    Intermediate = JuniorHigh | HighSchool,
    Advanced = HighSchool | College,
    AllAges = Preschool | Elementary | JuniorHigh | HighSchool | College
    
}