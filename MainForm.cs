using Balls.Common;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBalls;
        PointBall pointBall;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var countBalls = 0;
            foreach (var ball in moveBalls)
            {
                ball.Stop();
                if (ball.IsOut())
                {
                    countBalls++;
                }
            }
            MessageBox.Show(countBalls.ToString());
            StopButton.Enabled = false;
            ClearButton.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            ClearButton.Enabled = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }
            StartButton.Enabled = true;
            ClearButton.Enabled = false;
        }
    }
}
