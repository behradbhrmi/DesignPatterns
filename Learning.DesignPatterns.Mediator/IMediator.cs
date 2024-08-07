namespace Learning.DesignPatterns.Mediator;

public interface IMediator
{
    void Notify(object sender, string ev);
}

