// See https://aka.ms/new-console-template for more information
Weapon weapon = new Weapon("Sword", 5);
Player player = new Player(100, weapon);
Enemy enemy = new Enemy("Max", 30, 16);

while (enemy.IsAlive) {
    player.AttackEnemy(enemy);
}
Console.ReadLine();