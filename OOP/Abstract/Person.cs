namespace ObjectOrientedProgramming.OOP.Abstract;

public class Person
{
    public string Name { get; set; }
    
    public string Age { get; set; }
    
    public string Country { get; set; }

    public void PersonInfo()
    {
        Console.WriteLine($"Person Name : {Name} Person Age : {Age} Person Country : {Country}");
    }
}