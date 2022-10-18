using System.Media;
namespace Maze_Rework
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
            Cursor cur = new Cursor(Properties.Resources.icons8_red_circle_48.Handle);
            this.Cursor = cur;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Point X = this.Location;
            Cursor.Position = new Point(X.X + 30, X.Y + 40);
        }

        private void label28_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer S = new SoundPlayer(Properties.Resources.applause_8);
            S.Play();
            int minutes = I / 60;
            int seconds = I % 60;
            if (minutes > 0)
            {
                if (minutes == 1)
                {
                    if (seconds == 1)
                    {
                        DialogResult = MessageBox.Show("Congratulations you won in " + minutes.ToString() + " minute and " + seconds.ToString() + " second\nWanna Play again ?!", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        DialogResult = MessageBox.Show("Congratulations you won in " + minutes.ToString() + " minute and " + seconds.ToString() + " seconds\nWanna Play again ?!", "", MessageBoxButtons.YesNo);
                    }
                }
                else
                {
                    if (seconds == 1)
                    {
                        DialogResult = MessageBox.Show("Congratulations you won in " + minutes.ToString() + " minutes and " + seconds.ToString() + " second\nWanna Play again ?!", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        DialogResult = MessageBox.Show("Congratulations you won in " + minutes.ToString() + " minutes and " + seconds.ToString() + " seconds\nWanna Play again ?!", "", MessageBoxButtons.YesNo);
                    }
                }
            }
            else
            {
                DialogResult = MessageBox.Show("Congratulations you won in " + I.ToString() + " Seconds\nWanna Play again ?!", "yaaaaaaaaaaaaay", MessageBoxButtons.YesNo);
            }
            if (DialogResult == DialogResult.Yes)
            {
                Point X = this.Location;
                Cursor.Position = new Point(X.X + 30, X.Y + 40);
                I = 0;
            }
            else
            {
                this.Close();
            }

        }
        int I = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            I++;
        }

        private void Maze_Load(object sender, EventArgs e)
        {
            Point X = this.Location;
            Cursor.Position = new Point(X.X + 30, X.Y + 40);
            timer1.Start();
            this.MaximizeBox = false;
        }

        private void Maze_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}