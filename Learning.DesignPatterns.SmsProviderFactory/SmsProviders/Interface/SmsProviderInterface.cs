namespace Learning.DesignPatterns.SmsProvider.Factory.SmsProviders.Interface;

public interface ISmsProvider
{
    public void SendSms(string user, string message);
}
