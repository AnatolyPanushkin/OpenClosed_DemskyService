namespace AbstractFactory.FactoryMethods;

public class ElfFactory:CharacterFactory
{
    public override Movement CreateMovement()
    {
        return new MovementFly();
    }

    public override Weapon CreateWeapon()
    {
        return new Bow();
    }
}