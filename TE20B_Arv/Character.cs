using System;

public class Character
{
  public string Name { get; set; }
  public int ForceSensitivity { get; set; } = 0;
  public int ForceSide { get; set; } = 0;

  public int Hitpoints { get; set; } = 100;
}
