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
            answer = Letter.c,
            choices = new Dictionary<Letter, string>()
            {
                {Letter.a,"18"},
                {Letter.b,"27"},
                {Letter.c,"26"},
                {Letter.d,"29"}
            }
        };


        yield return new Quiz
        {
            question = "What is my favorite food?",
            choices = new Dictionary<Letter, string>()
            {
                {Letter.a,"Adobo"},
                {Letter.b,"Pakbet"},
                {Letter.c,"Sinigang"},
                {Letter.d,"Kare-kare"}
            }
            answer = Letter.d,
        };

    }
}