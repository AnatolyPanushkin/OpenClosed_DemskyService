namespace AbstractFactory.FactoryMethods;

public class OrcFactory:CharacterFactory
{
    public override Movement CreateMovement()
    {
        return new MovementRun();
    }

    public override Weapon CreateWeapon()
    {
        return new Sword();
    }
}