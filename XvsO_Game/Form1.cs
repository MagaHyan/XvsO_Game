namespace XvsO_Game
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }
        Player player;
        Random random = new Random();
        int playersWinsCount = 0;
        int computerWinsCount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            player = Player.X;
            button.Text = player.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.OrangeRed;
            buttons.Remove(button);
            CheckWin();
            Timer.Start();
            player = Player.O;
        }
        private void ComputerClick(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Text = player.ToString();
                buttons[index].Enabled = false;
                buttons[index].BackColor = System.Drawing.Color.Crimson;
                buttons.RemoveAt(index);
                CheckWin();
                player = Player.X;
                Timer.Stop();  
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            StartNewGame();
            computerWinsCount = 0;
            playersWinsCount = 0;
            ComputerWinsCount.Text = computerWinsCount.ToString();
            PlayerWinsCount.Text = playersWinsCount.ToString();
        }
        private void CheckWin()//lav sencel kasxhati:))
        {
            if (button1.Text == player.ToString() && button2.Text == player.ToString() && button3.Text == player.ToString() ||
               button4.Text == player.ToString() && button5.Text == player.ToString() && button6.Text == player.ToString() ||
               button7.Text == player.ToString() && button8.Text == player.ToString() && button9.Text == player.ToString() ||
               button1.Text == player.ToString() && button4.Text == player.ToString() && button7.Text == player.ToString() ||
               button2.Text == player.ToString() && button5.Text == player.ToString() && button8.Text == player.ToString() ||
               button3.Text == player.ToString() && button6.Text == player.ToString() && button9.Text == player.ToString() ||
               button1.Text == player.ToString() && button5.Text == player.ToString() && button9.Text == player.ToString() ||
               button3.Text == player.ToString() && button5.Text == player.ToString() && button7.Text == player.ToString())
            {
                Timer.Stop();
                if (player == Player.X)
                {
                    MessageBox.Show("Congrats!! You Win.");
                    playersWinsCount++;
                    PlayerWinsCount.Text = playersWinsCount.ToString();
                    StartNewGame();
                }
                else
                {
                    MessageBox.Show("Oyy... You are loser :(");
                    computerWinsCount++;
                    ComputerWinsCount.Text = computerWinsCount.ToString();
                    StartNewGame();
                }
            }
            else
            {
                if (buttons.Count == 0)
                {
                    MessageBox.Show(" Tie!!!Start a new Game ");
                    Thread.Sleep(2000);
                    playersWinsCount++;
                    computerWinsCount++;
                    ComputerWinsCount.Text = computerWinsCount.ToString();
                    PlayerWinsCount.Text = playersWinsCount.ToString();
                    StartNewGame();
                }
            }
        }
        private void StartNewGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button x in buttons)
            {
                x.Text = "?";
                x.Enabled = true;
                x.BackColor = default(Color);
            }
        }
    }
}