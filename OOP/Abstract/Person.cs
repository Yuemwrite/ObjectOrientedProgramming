using System.Net.Http.Headers;

namespace ObjectOrientedProgramming.OOP.Abstract;

public class Person
{
    public string Name { get; set; }
    
    private string Age { get; set; }
    
    public string Country { get; set; } 

    public void PersonInfo()
    {
        Console.WriteLine($"Person Name : {Name} Person Age : {Age} Person Country : {Country}");
    }

    public string PersonAge(string Age)
    {
        this.Age = Age;
        
        Console.WriteLine($"Yaş : {Age}");
        return Age;
    }
} 