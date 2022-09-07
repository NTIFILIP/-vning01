public class Player
{
    int health;
    Weapon weapon;

    public Player(int health, Weapon weapon) {
        this.health = health;
        this.weapon = weapon;
    }

    public void AttackEnemy(Enemy enemy) {
        System.Console.WriteLine("Attack enemy");
        this.weapon.Attack(enemy, this.weapon.Damage);
    }
}
