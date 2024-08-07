namespace Learning.DesignPatterns.Mediator;

public class ConcreteMediator : IMediator
{
    private ComponentA _componentA;
    private ComponentB _componentB;

    public ConcreteMediator(ComponentA componentA, ComponentB componentB)
    {
        _componentA = componentA;
        _componentA.SetMediator(this);
        _componentB = componentB;
        _componentB.SetMediator(this);
    }

    public void Notify(object sender, string e)
    {
        if (e == "A")
        {
            Console.WriteLine("Component A is being used");
            _componentA.DoSomethingA();
        }
        if (e == "B")
        {
            Console.WriteLine("Component B is being used");
            _componentA.DoSomethingB();
            _componentB.DoSomethingC();
        }
    }
}
