using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        List<Quiz> quizzes = InitializeQuiz().ToList();

        QuizManager quizManager = new QuizManager();
        quizManager.SetQuiz(quizzes);
        quizManager.ShowQuiz();
    }

    private static IEnumerable<Quiz> InitializeQuiz()
    {
        yield return new Quiz
        {
            question = "How old I am?",
            answer = Letter.c
        };
       

        yield return new Quiz
        {
            question = "What is my favorite food?",
            answer = Letter.d
        };
      
    }
}