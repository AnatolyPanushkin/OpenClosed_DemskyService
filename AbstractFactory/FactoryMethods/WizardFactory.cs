namespace AbstractFactory.FactoryMethods;

public class WizardFactory:CharacterFactory
{
    public override Movement CreateMovement()
    {
        return new MovementFly();
    }

    public override Weapon CreateWeapon()
    {
        return new MagicWand();
    }
}