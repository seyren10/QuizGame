using System.Collections;
using System.Collections.Generic;

public static class QuizInit
{
#region Personal_Quiz
   public static IEnumerable<Quiz> InitializeQuiz()
    {
        yield return new Quiz
        {
            question = "How old I am?",
            choices = new Dictionary<Letter, string>()
            {
                {Letter.a,"18"},
                {Letter.b,"27"},
                {Letter.c,"26"},
                {Letter.d,"29"}
            },
            answer = Letter.c,
            scorePoints = 30
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
            },
            answer = Letter.d, 
            scorePoints = 90
        };

        yield return new Quiz
        {
            question = "What is my favorite programming language?",
            choices = new Dictionary<Letter, string>()
            {
                {Letter.a,"Python"},
                {Letter.b,"C#"},
                {Letter.c,"Java"},
                {Letter.d,"Javascript"}
            },
            answer = Letter.b,
            scorePoints = 1000
        };

        yield return new Quiz
        {
            question = "Who cooks better, Roy or Corine?",
            choices = new Dictionary<Letter, string>()
            {
                {Letter.a,"Roy"},
                {Letter.b,"Corine"}
            },
            answer = Letter.b,
             scorePoints = 50
        };

        yield return new Quiz
        {
            question = "Corine's favorite band?",
            choices = new Dictionary<Letter, string>()
            {
                {Letter.a,"Panic! at the disco"},
                {Letter.b,"Fallout boys"},
                {Letter.c,"20 Seconds to Mars"},
                {Letter.d,"Cage the elephant"},
            },
            answer = Letter.a,
            scorePoints = 150
        };
    }
  #endregion
#region Philippine Trivia
  public static IEnumerable<Quiz> PhTriviaQuiz()
  {
    yield return new Quiz
    {
      question = "Which city is known as the \"Walled City?\"",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Malolos"},
        {Letter.b,"Intramuros"},
        {Letter.c,"Makati"}
      },
      answer = Letter.b,
      scorePoints = 100
    };

    yield return new Quiz
    {
      question = "Which country occupied the Philippines during World War II?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"German"},
        {Letter.b,"America"},
        {Letter.c,"Japan"}
      },
      answer = Letter.c,
      scorePoints = 30
    };

    yield return new Quiz
    {
      question = "Philippines Independence Day is celebrated on what date?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"June 12"},
        {Letter.b,"August 12"},
        {Letter.c,"July 11"}
      },
      answer = Letter.a,
      scorePoints = 50
    };

    yield return new Quiz
    {
      question = "The Bataan Death March took place in what year?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"1890"},
        {Letter.b,"1942"},
        {Letter.c,"1950"}
      },
      answer = Letter.b,
      scorePoints = 150
    };

    yield return new Quiz
    {
      question = "Who was known as the \"Hero of Tirad Pass?\"",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Gregorio Del Pilar"},
        {Letter.b,"Andres Bonifacio"},
        {Letter.c,"Dr. Jose Rizal"}
      },
      answer = Letter.a,
      scorePoints = 200
    };

    yield return new Quiz
    {
      question = "In what year did the Portuguese explorer Ferdinand Magellan arrive in the shores of Philippines?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"1521"},
        {Letter.b,"1420"},
        {Letter.c,"1621"}
      },
      answer = Letter.a,
      scorePoints = 200
    };

    yield return new Quiz
    {
      question = "Mayon Volcano is located in which province?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Cagayan"},
        {Letter.b,"Albay"},
        {Letter.c,"Zambales"}
      },
      answer = Letter.b,
      scorePoints = 90
    };

    yield return new Quiz
    {
      question = "Who was the first Filipina to win the Miss International beauty title in 1964?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Margarita Moran"},
        {Letter.b,"Gloria Diaz"},
        {Letter.c,"Gemma Cruz"}
      },
      answer = Letter.c,
      scorePoints = 390
    };

    yield return new Quiz
    {
      question = "Gloria Diaz won the Miss Universe contest in what year?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"1969"},
        {Letter.b,"1951"},
        {Letter.c,"1970"}
      },
      answer = Letter.a,
      scorePoints = 200
    };

    yield return new Quiz
    {
      question = "What pen name did Marcelo H del Pilar use in his writings?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Plaridel"},
        {Letter.b,"Parker"},
        {Letter.c,"Mongol"}
      },
      answer = Letter.a,
      scorePoints = 150
    };

    yield return new Quiz
    {
      question = "Which Filipino boxer is known for his nickname \"Pac-Man?\"",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Efren \"Bata\" Reyes"},
        {Letter.b,"Manny Paquiao"},
        {Letter.c,"Penalosa"}
      },
      answer = Letter.b,
      scorePoints = 50
    };

    yield return new Quiz
    {
      question = "Who said this immortal words \"A Filipino is worth dying for?\"",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Ninoy Aquino"},
        {Letter.b,"Diosdado Macapagal"},
        {Letter.c,"Emilio Jacinto"}
      },
      answer = Letter.a,
      scorePoints = 10
    };

    yield return new Quiz
    {
      question = "What is a fertilized duck egg called?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Tukneneng"},
        {Letter.b,"Penoy"},
        {Letter.c,"Balut"}
      },
      answer = Letter.c,
      scorePoints = 35
    };

    yield return new Quiz
    {
      question = "What is the original name of Luneta park?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Luneta Park"},
        {Letter.b,"Bagumbayan"},
        {Letter.c,"Pook Pasyalan"}
      },
      answer = Letter.b,
      scorePoints = 150
    };

    yield return new Quiz
    {
      question = "What are the provinces that consist of the acronym CALABARZON? (Name them)",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Cagayan, Landusan, Baguio, Romblon, Quinaguitman"},
        {Letter.b,"Cavite, Laguna, Batangas, Rizal, Quezon"},
        {Letter.c,"Capiz, Langob, Bohol, Rosario, Quirhat"}
      },
      answer = Letter.b,
      scorePoints = 100
    };

    yield return new Quiz
    {
      question = "Mt Pinatubo is located in the province of Luzon at the intersection of the borders of the provinces of Zambales, Tarlac, and ______.",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Pampanga"},
        {Letter.b,"Lapaz"},
        {Letter.c,"Nueva Ecija"}
      },
      answer = Letter.a,
      scorePoints = 85
    };

    yield return new Quiz
    {
      question = "Where in Manila can you find the San Agustin Church?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Batangas"},
        {Letter.b,"Metro Manila"},
        {Letter.c,"Intramuros"}
      },
      answer = Letter.c,
      scorePoints = 130
    };

     yield return new Quiz
    {
      question = "\"Pahiyas\" is a festival celebrated every May in which town in Quezon province?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Palawan"},
        {Letter.b,"Luban"},
        {Letter.c,"Laoag"}
      },
      answer = Letter.b,
      scorePoints = 130
    };

    yield return new Quiz
    {
      question = "Smallest Provice of the Philippines?",
      choices = new Dictionary<Letter, string>()
      {
        {Letter.a,"Guimaras"},
        {Letter.b,"Batanes"},
        {Letter.c,"Antique"}
      },
      answer = Letter.b,
      scorePoints = 350
    };
  }
#endregion
}