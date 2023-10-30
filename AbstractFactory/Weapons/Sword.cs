namespace AbstractFactory;

public class Sword:Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Атака мечом");
    }
}