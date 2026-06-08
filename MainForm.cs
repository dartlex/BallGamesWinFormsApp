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
            for (int i = 0; i < 10; i++)
            {
                moveBalls[i].Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
