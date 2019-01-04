using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Final
{
    class Win_loss_class
    {

        static public void WinLose()
        {
            int win;
            int loss;
            int ScoreWins = 0;
            int ScoreLoss = 0;
            int round;
            int PlayerCards = 0;
            int PcCards = 0;
            int War;

            if (PcCards < PlayerCards)
            {
                ScoreLoss++;
                Write("You lost the round");
            }
            else if (PlayerCards < PcCards)
            {

                ScoreWins++;
                WriteLine("You won the round");
            }   
            
            else if (PlayerCards == PcCards)
            {
                WriteLine("War has been initiated");
                War
            }
           

            
        }

    }
}
