using System;
using System.Collections.Generic;
using System.Text;

namespace BallGamesWinFormsApp
{
    public class RandomMove : RandomPointBall
    {
        public RandomMove(MainForm form) : base(form)
        {
            vx = new Random().Next(-2, 2);
            vy = new Random().Next(-2, 2);
        }
    }
}
