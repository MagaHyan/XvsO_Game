namespace XvsO_Game
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X,O
        }

        Player player;
        Random random=new Random();
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
            player=Player.X;
            button.Text = player.ToString(); 
            button.Enabled=false;
            button.BackColor=System.Drawing.Color.OrangeRed;
            buttons.Remove(button);
            Check();
            Timer.Start();
        }

        private void ComputerClick(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                player = Player.O; 
                buttons[index].Text = player.ToString();
                buttons[index].Enabled=false;
                buttons[index].BackColor=System.Drawing.Color.Crimson;
                buttons.RemoveAt(index);
                Check();
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
        
        private void Check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
               button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
               button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
               button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
               button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
               button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                Timer.Stop();
                MessageBox.Show("Congretion!! You Win.");
                playersWinsCount++;
                PlayerWinsCount.Text = playersWinsCount.ToString();
                StartNewGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
               button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
               button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
               button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
               button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
               button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
               button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
               button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                Timer.Stop();
                MessageBox.Show("Oyy... You are loser :(");
                playersWinsCount++;
                ComputerWinsCount.Text = computerWinsCount.ToString();
                StartNewGame();
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