namespace ObjectOrientedProgramming.OOP.BasicPrinciples.Encapsulation;

public class UserControl
{
    private string userName { get; set; }
    
    private string password { get; set; }

    public string UserName
    {
        get
        {
            return userName;
        }
        set
        {
            bool result = true;
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    result = false;
                    break;
                }
            }

            if (result)
            {
                userName = value;
            }
            else
            {
                Console.Write($"Username cannot have numeric value");
            }
            
        }
    }

    public string Password
    {
        get
        {
            return password;
        }
        set
        {
            password = value;
        }
    }
}