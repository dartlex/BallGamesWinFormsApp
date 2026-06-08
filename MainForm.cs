namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBalls = new List<MoveBall>();
        int counter;
        Random random;
        int counterBall;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            counterBall = random.Next(5, 15);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (moveBalls == null || moveBalls.Count == 0) return;

            for (int i = 0; i < moveBalls.Count; i++)
            {
                moveBalls[i].Stop();
                if (!moveBalls[i].IsOut()) counter++;
            }

            MessageBox.Show(counter.ToString());
            counter = 0;
            this.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();
            }
            moveBalls.Clear();
            this.Invalidate();
            for (int i = 0; i < counterBall; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
            counterBall = random.Next(5, 15);
        }
    }
}
