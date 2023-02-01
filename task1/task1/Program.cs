namespace task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Username: ");

        string username = Console.ReadLine();

        string password;
        do
        {
            Console.WriteLine("Password: ");

            password = Console.ReadLine();

        } while (!User.CheckPassword(password));

      
        User user = new User();

        user.UserName = username;
        user.Password = password;
    }
}

