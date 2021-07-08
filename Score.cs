using System;

public class Score
{
  public int currentScore {get;set;}
  public int correctPoints {get;set;}

  public void AddPoints(int points)
  {
    currentScore += points;
    correctPoints++;
  }
}