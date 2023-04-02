namespace Strategy.Abstracts;

public abstract class Character 
{
    public string Name { get; set; }
    
    public abstract void Move();
    public abstract void Attack();
}