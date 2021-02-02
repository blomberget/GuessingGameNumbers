using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GissaNummer2
{
  public class HighScore
  {
    private FileStream fStream { get; set; }
    private StreamWriter sWriter { get; set; }
    private StreamReader sReader { get; set; }

    public HighScore()
    {
    }

    public bool SaveScore(List<Score> playerScore)
    {
      /* SaveScore skriver ner innehållet från List<Score> i en textfil och om allt
      gick bra returneras true annars returneras false.Tänk på att nya spel ska
      sparas i slutet av textfilen som finns, så inga gamla spel skrivs över. */

      List<Score> Scores = playerScore;

      try
      {
        sWriter = new StreamWriter(@"/Users/fina/Documents/Universitet/Projects/GissaNummer2/Highscore.txt", true, Encoding.ASCII);

        foreach (Score score in Scores)
        {
          sWriter.WriteLine($"{score.Name} - {score .Guess}");
        }
        sWriter.Close();
        return true;
      }

      catch (Exception e)
      {
        Console.WriteLine("Exception: " + e.Message);
        return false;
      }
    }

    public List<Score> PrintScore()
    {
      if (File.Exists(@"/Users/fina/Documents/Universitet/Projects/GissaNummer2/Highscore.txt"))
      {
        try
        {
          string line = "";

          sReader = new StreamReader(@"/Users/fina/Documents/Universitet/Projects/GissaNummer2/Highscore.txt");

          while ((line = sReader.ReadLine()) != null)
          {
            Console.WriteLine(line);
          }

          return null;
        }

        catch (Exception e)
        {
          Console.WriteLine("Exception: " + e.Message);
          return null;
        }
      }

      else
      {
        Console.WriteLine("Inga highscores registrerade");
        return null;
      }

    }
  }
}




