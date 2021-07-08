using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        List<Quiz> quizzes = QuizInit.PhTriviaQuiz().ToList();

        QuizManager quizManager = new QuizManager(new Score());
        quizManager.SetQuiz(quizzes);
        quizManager.ShowQuiz();

    }
}