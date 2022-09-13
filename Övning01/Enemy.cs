using System.Globalization;
using System;

public class Enemy : Humanoid
{
    public Enemy(string name, int health, Weapon weapon) {
        this.Name = name;
        this.weapon = weapon;
        this.health = health;
        this.IsAlive = true;
    }
}
