using System;

public class Crystal : Item
{
  public Crystal()
  {
    Name = "Crystal";
    Random generator = new Random();

    Rarity = generator.Next(1, 5);
  }
}
