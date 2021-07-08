using System;
using System.Collections;
using System.Collections.Generic;

public class Quiz
{
    public Letter answer { get; set; }
    public string question { get; set; }
    public Dictionary<Letter, string> choices { get; set; }
    public int scorePoints {get;set;}
}

public enum Letter
{
    a,
    b,
    c,
    d
}


