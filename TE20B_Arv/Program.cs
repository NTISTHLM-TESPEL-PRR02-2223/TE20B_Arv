Character c = new Sith();

List<Weapon> weapons = new();

weapons.Add(new Bazooka());

Weapon b = new Bazooka();

if (b is Bazooka)
{
  ((Bazooka)b).Range = 900;
}



Weapon w = new Weapon();

w.Attack(c);

Console.ReadLine();