namespace AbstractFactory;

public class MagicWand:Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Атака заклинанием");
    }
}