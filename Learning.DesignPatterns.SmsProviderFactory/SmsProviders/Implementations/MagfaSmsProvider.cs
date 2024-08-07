using Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Interface;

namespace Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Implementations;

internal class MagfaSmsProvider : ISmsProvider
{
    public MagfaSmsProvider() { }

    public void SendSms(string user, string message)
    {
        Console.WriteLine($"________\n> Provider: Magfa  \n> message:{message}  \n> user: {user}");
    }
}
