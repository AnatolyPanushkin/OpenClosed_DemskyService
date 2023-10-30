namespace AbstractFactory;

public abstract class CharacterFactory
{
    public abstract Movement CreateMovement();
    public abstract Weapon CreateWeapon();
}