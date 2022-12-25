using ObjectOrientedProgramming.OOP.BasicPrinciples.Abstraction.Abstract;

namespace ObjectOrientedProgramming.OOP.BasicPrinciples.Abstraction.Concrete;

public class EditorUser : UserType
{
    public override void UserTypeShow(string name, string lastName, Enums.UserType type)
    {
        Console.WriteLine("Editor User");
        Console.Write($"Name : {name} -- LastName : {lastName} -- UserType : {type}");
    }
}