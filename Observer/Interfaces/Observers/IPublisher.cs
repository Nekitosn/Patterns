namespace Observer.Interfaces.Observers;

public interface IPublisher
{
    public void Attach(ISubscribed subscribed);
    
    public void Detach(ISubscribed subscribed);
    
    public void Notify();
}