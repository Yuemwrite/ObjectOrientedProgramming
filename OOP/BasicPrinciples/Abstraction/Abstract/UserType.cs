namespace ObjectOrientedProgramming.OOP.BasicPrinciples.Abstraction.Abstract;

public abstract class UserType
{
    public string Name { get; set; }

    public string LastName { get; set; }

    public Enums.UserType Type { get; set; }

    public abstract void UserTypeShow(string name, string lastName, Enums.UserType type);
}