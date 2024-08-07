using Learning.DesignPatterns.Mediator;

namespace Learning.DesignPatterns.Mediator;

public class ComponentA : BaseComponent
{
    public void DoSomethingA()
    {
        Console.WriteLine("Doing Something A");
        _mediator.Notify(this, "A");
    }
    public void DoSomethingB()
    {
        Console.WriteLine("Doing Something B");
        _mediator.Notify(this, "B");
    }
}

public class ComponentB : BaseComponent
{
    public void DoSomethingC()
    {
        Console.WriteLine("Doing Something C");
        _mediator.Notify(this, "B");
    }
}
