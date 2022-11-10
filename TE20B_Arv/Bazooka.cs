
public class Bazooka : RangedWeapon
{
  public Bazooka()
  {
    Name = "Bazooka";
    Range = 300;
    Damage = 20;
  }

  public override void Attack(Character target)
  {
    Console.WriteLine("Bazooka attack!");
    target.Hitpoints -= Damage;
    target.Hitpoints -= Damage;
  }
}
