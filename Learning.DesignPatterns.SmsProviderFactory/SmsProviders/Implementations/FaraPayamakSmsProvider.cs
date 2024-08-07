using Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Interface;

namespace Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Implementations;

public class FaraPayamakSmsProvider : ISmsProvider
{
    public FaraPayamakSmsProvider() { }

    public void SendSms(string user, string message)
    {
        Console.WriteLine($"________\n> Provider: FaraPayamak \n> message:{message}  \n> user: {user}");
    }
}