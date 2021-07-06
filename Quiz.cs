using System;
using System.Collections;
using System.Collections.Generic;

public class Quiz
{
  public Letter answer {get;set;}
  public string question {get;set;}

  private Dictionary<Letter,string> _choices = new Dictionary<Letter,string>();

  public void SetChoices(Letter letter, string option)
  {
    _choices.Add(letter,option);
  }

  public Dictionary<Letter,string> GetChoices()
  {
    return _choices;
  }
}

public enum Letter
{
  a,
  b,
  c,
  d
}


