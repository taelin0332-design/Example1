using System.Security.AccessControl;

namespace solution5
{
    public partial class Form1 : Form
    {
        private Random _rnd = new Random();

        private int _userScore = 0;  // 점수가 유지될 수 있도록 전역 변수로 선언
        private int _computerScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

            public enum Game // Form1안에 쓰려고 public으로 선언
        {
            Scissors,  // 0
            Rock,      // 1
            Paper      // 2


        }
        public enum Result
        {
                Win, 
                Lose,
                Draw

        }

        private Result Judge(Game user, Game computer)
        {
            if(user == computer)
            {
                return Result.Draw;
            }
            else if ((user == Game.Scissors && computer == Game.Paper) ||
                     (user == Game.Rock && computer == Game.Scissors) ||
                     (user == Game.Paper && computer == Game.Rock))
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }
        }

        private void UpdateScore(Result result)
        {
            if(result == Result.Win)
            {
                _userScore++;
            }
            else if(result == Result.Lose)
            {
                _computerScore++;
            }
            userScoreTextBox.Text = _userScore.ToString();
            computerScoreTextBox.Text = _computerScore.ToString();
        }

        private void ResetScores()
        {
            _userScore = 0;
            _computerScore = 0;
            userScoreTextBox.Text = "0";
            computerScoreTextBox.Text = "0";
        }

        private void EndGame()
        {     
            string finalMessage;
            if(_userScore > _computerScore)
            {
                finalMessage = "You win the game!";
            }
            else if(_userScore < _computerScore)
            {
                finalMessage = "Computer wins the game!";
            }
            else
            {
                finalMessage = "The game is a draw!";
            }
            MessageBox.Show(finalMessage, "Game Over");
            ResetScores();
        }

        private void PlayRound(Game userChoice)
        {
            Game computerChoice = (Game)_rnd.Next(0, 3);
            Result result = Judge(userChoice, computerChoice);
            UpdateScore(result);
            if(_userScore >= 3 || _computerScore >= 3)
            {
                EndGame();
            }
        }


        private void Rock_Click(object sender, EventArgs e)
        {
            PlayRound(Game.Rock);
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            PlayRound(Game.Paper);
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            PlayRound(Game.Scissors);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
