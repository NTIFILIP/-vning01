using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
Weapon weapon = new Weapon("Sword", 5);
Player player = new Player("Playero", 100, weapon);
Enemy enemy = new Enemy("Max", 16, weapon);

while (enemy.IsAlive && player.IsAlive) {
    player.AttackEnemy(enemy);
    if (enemy.IsAlive) {
        enemy.AttackEnemy(player);
    }
}
System.Console.WriteLine("Done!");
Console.ReadLine();