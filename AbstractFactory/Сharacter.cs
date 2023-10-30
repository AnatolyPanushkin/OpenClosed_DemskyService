namespace AbstractFactory;

public class Сharacter
{
    private Movement _movement;
    private Weapon _weapon;

    public Сharacter(CharacterFactory characterFactory)
    {
        _weapon = characterFactory.CreateWeapon();
        _movement = characterFactory.CreateMovement();
    }

    public void Move()
    {
        _movement.Move();
    }

    public void Attack()
    {
        _weapon.Hit();
    }
}