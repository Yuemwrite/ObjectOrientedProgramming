// See https://aka.ms/new-console-template for more information

using ObjectOrientedProgramming.OOP.Abstract;
using ObjectOrientedProgramming.OOP.BasicPrinciples.Abstraction.Abstract;
using ObjectOrientedProgramming.OOP.BasicPrinciples.Abstraction.Concrete;
using ObjectOrientedProgramming.OOP.BasicPrinciples.Encapsulation;
using ObjectOrientedProgramming.OOP.BasicPrinciples.Polymorphism.Base;
using ObjectOrientedProgramming.OOP.BasicPrinciples.Polymorphism.SubClasses;
using UserType = ObjectOrientedProgramming.OOP.Enums.UserType;

// Person person = new Person();
// person.Name = "Yunus Emre";
// person.Country = "Türkiye";
//
// //person.PersonInfo();
// person.PersonAge("32");

List<Database> databases = new List<Database>
{
    new SqlDatabase(),
    new OracleDatabase()
};

foreach (var database in databases)
{
    database.DatabaseSetting();
}