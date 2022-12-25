using ObjectOrientedProgramming.OOP.BasicPrinciples.Polymorphism.Base;

namespace ObjectOrientedProgramming.OOP.BasicPrinciples.Polymorphism.SubClasses;

public class SqlDatabase : Database
{
    public override void DatabaseSetting()
    {
        Console.WriteLine("Sql Database");
    }
}