using Strategy.Models;

Console.WriteLine("   Starting");

var warrior = new Warrior("Geralt");
var archer = new Archer("Legolas");

var game = new Game();

game.SetCharacter(warrior);

Console.WriteLine("\nPlaying with the warrior:");
game.Play();

game.SetCharacter(archer);

Console.WriteLine("\nPlaying with the archer:");
game.Play();

Console.WriteLine("\n   End program");
