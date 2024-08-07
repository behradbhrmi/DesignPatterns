using Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Interface;

using Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Implementations;

namespace Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Factory;

public class SmsProviderFactory
{
    public static ISmsProvider? Create(string smsProvider)
    {
        switch (smsProvider.ToLower())
        {
            case "magfa":
                return new MagfaSmsProvider();

            case "farapayamak":
                return new FaraPayamakSmsProvider();

            case "x":
                return new XSmsProvider();

            default:
                throw new ArgumentException("Not Supported, Enter a valid Provider");
        }
    }
}
