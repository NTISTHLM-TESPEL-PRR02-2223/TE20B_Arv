using System;

public class NPC : Character
{
  public string CurrentBehaviour { get; set; } = "shopping";
  
  public NPC()
  {
    Name = "Bengt";
  }
}
