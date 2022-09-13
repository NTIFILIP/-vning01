using System;

public class Humanoid
{
    protected int health;
    protected Weapon weapon;

    public string Name {get; protected set;}
    public bool IsAlive {get; protected set;}

    public void AttackEnemy(Humanoid target) {
        System.Console.WriteLine($"{Name} attacked {target.Name}");
        this.weapon.Attack(target, this.weapon.Damage);
    }

    void Die() {
        this.IsAlive = false;
        System.Console.WriteLine($"Enemy '{Name}' died.");
    }

    public void TakeDamage(int damage) {
        this.health -= damage;
        if (this.health <= 0) {
            Die();
        }
    }
}
