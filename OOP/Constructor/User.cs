namespace ObjectOrientedProgramming.OOP.Constructor;

public class User
{
    public string Name { get; set; }
    
    public string Code { get; set; }
    
    public User()
    {
        Console.WriteLine($"Yapıcı metot çalıştı.");
    }

    public User(string code, string name)
    {
        Code = code;
        Name = name;
        Console.WriteLine($"{Code}--{Name}");
    }
}