using System;
public class Ramesh
{
    private string Username;
    private int Password;
    public static void Main(string[] args)
    {
        Ramesh ramesh = new Ramesh();
        UseLogin(ramesh);
    }

    private static void UseLogin(Ramesh ramesh)
    {
        while (!ramesh.CorrectUser())
        {
            ramesh.AskForusernameandPassword();
            if (!ramesh.CorrectUser())
            {
                Console.WriteLine("Incorrect username and Password");
                Console.WriteLine("Try Again");
            }
        }
        if (ramesh.CorrectUser())
        {
            ramesh.Login();
        }
    }

    private void AskForusernameandPassword()
    {
        Console.WriteLine("Enter Username : ");
        Username = Console.ReadLine();
        Console.WriteLine("Enter Password in Numbers: ");
        Password = Convert.ToInt32(Console.ReadLine());
    }
    private void Login()
    {
        Console.WriteLine("LOGGED IN");
    }
    private bool CorrectUser()
    {
        string acutalUsername = "John";
        int actualPassWord = 123;
        if (Username == acutalUsername && Password == actualPassWord)
        {
            return true;
        }
        else return false;
    }
}