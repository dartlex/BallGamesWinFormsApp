using System;
using System.Collections.Generic;
using System.Text;

namespace BallGamesWinFormsApp
{
    public class Ball
    {
        private MainForm form;
        private int vx = 10;
        private int vy = 10;
        protected int x = 150;
        protected int y = 150;
        protected int size = 70;
        public Ball(MainForm form)
        {
            this.form = form;
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        private void Go()
        {
            x += vx;
            y += vy;
        }

        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = new SolidBrush(form.BackColor);
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        
    }
}
