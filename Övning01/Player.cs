public class Player : Humanoid
{
    public Player(string name, int health, Weapon weapon) {
        this.Name = name;
        this.health = health;
        this.weapon = weapon;
        this.IsAlive = true;
    }
}
