
public class Weapon
{
  public string Name  { get; set; }
  public int Damage { get; set; }

  public virtual void Attack(Character target)
  {
    Console.WriteLine("Attack!");
    target.Hitpoints -= Damage;
  }
}
