using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    List<Quiz> quizzes = InitializeQuiz().ToList();

    QuizManager quizManager = new QuizManager();
    quizManager.SetQuiz(quizzes);
    quizManager.ShowQuiz();
  }

  private static IEnumerable<Quiz> InitializeQuiz()
  {
    Quiz question1 = new Quiz {
      question = "How old I am?",
      answer = Letter.c
    };
    question1.SetChoices(Letter.a,"23");
    question1.SetChoices(Letter.b,"25");
    question1.SetChoices(Letter.c,"26");
    question1.SetChoices(Letter.d,"30");
    yield return question1;

    Quiz question2 = new Quiz{
      question = "What is my favorite food?",
      answer = Letter.d
    };
    question2.SetChoices(Letter.a,"Abodo");
    question2.SetChoices(Letter.b,"Bicol Express");
    question2.SetChoices(Letter.c,"Munggo");
    question2.SetChoices(Letter.d,"Kare-Kare");
    yield return question2;
  }
}