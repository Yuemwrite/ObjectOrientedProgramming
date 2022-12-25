using ObjectOrientedProgramming.OOP.BasicPrinciples.Abstraction.Abstract;

namespace ObjectOrientedProgramming.OOP.BasicPrinciples.Abstraction.Concrete;

public class AdminUser : UserType
{
    public override void UserTypeShow(string name, string lastName, Enums.UserType type)
    {
        Console.WriteLine("Admin User");
        Console.Write($"Name : {name} -- LastName : {lastName} -- UserType : {type}");
    }
}