using Learning.DesignPatterns.SmsProvider.Factory.Models;
using Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Interface;


namespace Learning.DesignPatterns.SmsProvider.Factory;

public static class Authentication
{
    private static UserModel? CheckCredential(Credential credential)
    {
        //using var db = new DataContext();
        //return db.Users.Where(u => u.Username == credential.Username && u.Password == credential.Password).FirstOrDefault();
        return new();
    }

    private static Credential GetCredential()
    {
        Credential credential = new();
        Console.WriteLine("__Login__");
        Console.WriteLine("Username:");
        credential.Username = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Password:");
        credential.Password = Console.ReadLine() ?? string.Empty;
        return credential;
    }

    public static void Login(ISmsProvider smsProvider)
    {
        string message = $"you logged into your account at {DateTime.Now}";

        var result = CheckCredential(GetCredential());

        if (result != null)
            smsProvider.SendSms(result.Username, message);
        else
            Console.WriteLine("> Username or Password is Incorrect");
    }
}
