using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class QuizManager
{
  private List<Quiz> _quizList;
  private Quiz _activeQuiz;
  private Score score;

  public QuizManager(Score score)
  {
    this.score = score;
  }
  
  public void SetQuiz(List<Quiz> quizzes)
  {
    _quizList = quizzes;
  }

  public void ShowQuiz()
  {
    var uniqueRandom = new UniqueRandom();
    for(int x = 0; x < _quizList.Count; x++)
    {
      Console.Clear();
      //score Board
      Utils.CustomConsole($"🔥 Score: {score.currentScore}  🔥",ConsoleColor.Magenta);

      //quiz status
      float we = x+1;
      float wee = _quizList.Count;
      float quizPercent = (we / wee) * 100f;
      string quizStatus = $"🧠 Question: {x+1} of {_quizList.Count}. {quizPercent:0}%";
      Utils.CustomConsole(quizStatus, ConsoleColor.Blue);

      var rand = uniqueRandom.GetRandom(_quizList.Count);
      _activeQuiz = _quizList[rand];

      //display question
      DisplayQuestion();

      //display choices
      foreach(var key in _activeQuiz.choices)
      {
        Console.WriteLine("{0}. {1}", key.Key, key.Value);
      }
      EvaluateAnswer();
    }


    //finishing message
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"Total : {score.correctPoints}/{_quizList.Count}");
  }

  private void DisplayQuestion()
  {
    string questionString = _activeQuiz.question + $"({_activeQuiz.scorePoints} points ❤️ )";
    Utils.CustomConsole(questionString,ConsoleColor.Yellow);
    Utils.DrawLine(_activeQuiz.question.Length,"-");
  }

  private void EvaluateAnswer()
  {
    if(UserInput() == _activeQuiz.answer)
    {
      Utils.CustomConsole("Correct! 😊",ConsoleColor.Green,2000);
      score.AddPoints(_activeQuiz.scorePoints);
    }
    else
    {
       Utils.CustomConsole("Wrong! 😞",ConsoleColor.Red);
       CorrectAnswer();
    }
  }

  private void CorrectAnswer()
  {
    var key = _activeQuiz.answer;
    var kvp = new KeyValuePair<Letter,string>(key, _activeQuiz.choices[key]);

    Console.Write("Correct Answer: ");
    Utils.CustomConsole($"{kvp.Key.ToString().ToUpper()}. {kvp.Value}",ConsoleColor.Green,3000);
  }

  private Letter UserInput()
  {
    Utils.DrawLine(_activeQuiz.question.Length,"-");
    Console.Write("Choose your answer: ");
    string input = Console.ReadLine().ToLower();

    //checking if the user enter a letter within a given letter choices
    var letterList = _activeQuiz.choices;
    foreach(var letter in letterList)
      if(letter.Key.ToString() == input)
        return letter.Key;
    
    //the user enter an invalid letter
    Utils.CustomConsole("Invalid Letter",ConsoleColor.Red,1000);
    return UserInput();
    
  }

  //generate unique number within a given integer size
  private class UniqueRandom
  {
    private List<int> uniqueList = new List<int>();

    public int GetRandom(int size)
    {
      Random rand = new Random();
      int value = rand.Next(size);
      if(!uniqueList.Contains(value))
      {
        uniqueList.Add(value);
        return value;
      }
      return GetRandom(size);
    }
  }
}

