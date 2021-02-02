using System;
using System.Collections.Generic;

namespace GissaNummer2
{
  public class UI
  {
      private HighScore scoreList { get; set; }
      // scoreList av typen HighScore för att vi ska kunna anropa den klassen för att skriva ut listan

      private List<Score> printList { get; set; }
      //printList av typen List<Score> ska hålla i det som hämtas från textfilen.

      public UI()
      {
      // Konstruktorn UI som instansierar scoreList - och printList - objekten
      HighScore scoreList = new HighScore();
      List<Score> printList = new List<Score>();

      }

      public string DrawUI()
      {
      Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXX");
      Console.WriteLine("Välkommen till gissa nummret");
      Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXX\n");
      Console.WriteLine("Highscores:");

      HighScore highestScorer = new HighScore();
      highestScorer.PrintScore();

      Console.WriteLine("\nStarta spel?\nja/nej\n");
        string answer = Console.ReadLine();
        return answer;
      }


    }
  }
