using System;


public class Tool : Item
{
  public Tool()
  {
    Name = "Tool";
    Random generator = new Random();

    Rarity = generator.Next(1, 3);
  }
}
