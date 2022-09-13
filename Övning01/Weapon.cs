using System;

public class Weapon
{
    string name;

    public int Damage { get; }
   
    public Weapon(string name, int damage) {
        this.name = name;
        this.Damage = damage;
    }

    public void Attack(Humanoid enemy, int damage) {
        enemy.TakeDamage(damage);
    }
}
