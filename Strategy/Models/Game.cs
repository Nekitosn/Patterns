using Strategy.Abstracts;

namespace Strategy.Models;

public class Game 
{
    private Character _character;

    public void SetCharacter(Character character) 
    {
        _character = character;
    }

    public void Play() 
    {
        _character.Move();
        _character.Attack();
    }
}