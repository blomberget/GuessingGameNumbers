using System;

namespace GissaNummer2
{
  class Program : GuessNumber
  {
    static void Main(string[] args)
    {
      UI UIgame = new UI();
      GuessNumber GNgame = new GuessNumber();

      

      string a = UIgame.DrawUI();

      GNgame.PlayGame(a);
    }
  }
}
