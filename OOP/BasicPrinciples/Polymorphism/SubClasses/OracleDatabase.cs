using ObjectOrientedProgramming.OOP.BasicPrinciples.Polymorphism.Base;

namespace ObjectOrientedProgramming.OOP.BasicPrinciples.Polymorphism.SubClasses;

public class OracleDatabase : Database
{
    public override void DatabaseSetting()
    {
        Console.WriteLine("Oracle Database");
    }
}