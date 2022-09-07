using System.Globalization;
using System;

public class Enemy
{
    string name;
    int damage;
    int health;
    public bool IsAlive {get; private set;}

    public Enemy(string name, int damage, int health) {
        this.name = name;
        this.damage = damage;
        this.health = health;
        this.IsAlive = true;
    }

    void Die() {
        this.IsAlive = false;
        System.Console.WriteLine($"Enemy '{name}' died.");
    }

    public void TakeDamage(int damage) {
        this.health -= damage;
        if (this.health <= 0) {
            Die();
        }
    }
}
