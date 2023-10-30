using System.Runtime.InteropServices.ComTypes;

namespace AbstractFactory;

public class MovementRun:Movement
{
    public override void Move()
    {
        Console.WriteLine("Бежать");
    }
}