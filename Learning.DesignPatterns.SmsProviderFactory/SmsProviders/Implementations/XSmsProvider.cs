using Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Interface;

namespace Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Implementations;

internal class XSmsProvider : ISmsProvider
{
    public XSmsProvider() { }

    public void SendSms(string user, string message)
    {
        Console.WriteLine($"________\n> Provider: X \n> message:{message}  \n> user: {user}");
    }
}
