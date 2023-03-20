namespace Observer.Interfaces.Observers;

public interface ISubscribed
{
    public void Update(IPublisher publisher);
}