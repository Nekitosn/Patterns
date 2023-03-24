namespace Observer.Interfaces.Observers;

public interface ISubscriber
{
    public void Update(IPublisher publisher);
}