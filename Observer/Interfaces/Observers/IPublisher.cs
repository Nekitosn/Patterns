namespace Observer.Interfaces.Observers;

public interface IPublisher
{
    public void Attach(ISubscriber subscriber);
    
    public void Detach(ISubscriber subscriber);
    
    public void Notify();
}