using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
public class QuizManager
{
  private List<Quiz> _quizList = new List<Quiz>();
  private Quiz _activeQuiz;
  private int delay = 2000; // in millisecond
  
  public void SetQuiz(List<Quiz> quizzes)
  {
    _quizList = quizzes;
  }

  public void SetQuiz(params Quiz[] quizzes)
  {
    _quizList = new List<Quiz>(quizzes);
  }

  public void ShowQuiz(int start=0)
  {
    for(int x = start; x < _quizList.Count; x++)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.White; // reset console ConsoleColor

      _activeQuiz = _quizList[x];
      Console.WriteLine($"Question: {_activeQuiz.question}");

      foreach(var key in _activeQuiz.GetChoices())
      {
        Console.WriteLine("{0}. {1}", key.Key, key.Value);
      }
      EvaluateAnswer();
    }
  }

  private void EvaluateAnswer()
  {
    if(UserInput() == _activeQuiz.answer)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("You got it Right!");
      Thread.Sleep(delay);
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You Noob");
      Thread.Sleep(delay);
    }
  }

  private Letter UserInput()
  {
    Console.Write("Choose your answer: ");
    string input = Console.ReadLine().ToLower();

    //checking if the user enter a letter within a given letter choices
    var letterList = _activeQuiz.GetChoices();
    foreach(var letter in letterList)
      if(letter.Key.ToString() == input)
        return letter.Key;
    
    //the user enter an invalid letter
    Console.WriteLine("Invalid Input!");
    Thread.Sleep(delay);
    return UserInput();
    
  }
}