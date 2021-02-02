using System;
using System.Collections.Generic;

namespace GissaNummer2
{
  public class GuessNumber
  {
    private bool runGame { get; set; }
    private Score gameScore { get; set; }
    private HighScore scoreList { get; set; }

    public GuessNumber()
    { //Konstruktorn GuessNumber som instansierar gameScore och scoreList.
      Score gameScore = new Score();
      HighScore scoreList = new HighScore();
    }

    public void PlayGame(string pg)
    {
      WillPlay(pg);

      runGame = WillPlay(pg);

      List<int> totalGuesses = new List<int>();

      List<Score> playerScores = new List<Score>();

      int totali = 0;
      string player = "";


      while (runGame == true)
      {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);

        int guess = 0;
        int i = 0;

        Console.WriteLine($"Gissa talet\n");

        while (guess != numberToGuess)
        {
          guess = int.Parse(Console.ReadLine());

          if (guess > numberToGuess)
          {
            Console.WriteLine("\nTalet är lägre än det du gissade på. Försök igen.");
            i++;
            Console.WriteLine("Du har hittills gissat " + i + " gånger\n");
          }
          else if (guess < numberToGuess)
          {
            Console.WriteLine("\nTalet är högre än det du gissade på. Försök igen.");
            i++;
            Console.WriteLine("Du har hittills gissat " + i + " gånger\n");
          }
        }

        totali = i + 1;
        totalGuesses.Add(totali);


        Console.WriteLine($"\nRätt! Talet var {numberToGuess}. \nDet tog dig {totali} gissningar.\n");

        Console.WriteLine("\nAnge ditt namn: \n");
        player = Console.ReadLine();

        Console.WriteLine($"Vill du spela igen?\nja/nej\n");
        string a = Console.ReadLine();
        a.ToLower();

        runGame = WillPlay(a);

        Score roundScore = new Score();

        roundScore.Name = player;
        roundScore.Guess = totali;

        playerScores.Add(roundScore);

      }

      HighScore hs = new HighScore();
      hs.SaveScore(playerScores);


      Console.WriteLine("\nAntal gissningar gissningar per omgång: ");
      foreach (var guesses in totalGuesses)
      {
        Console.WriteLine(guesses);
      }



      Console.WriteLine($"\nHejdå!");
    }


    private bool WillPlay(string a)
    {
      if (a.ToLower() == "ja")
      {
        return true;
      }

      return false;
    }



  }
}
