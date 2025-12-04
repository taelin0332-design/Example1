namespace solution3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool coin = true;
            bool game = Cointoss(coin);
            textBox1.Text = game ? "½Â¸®" : "ÆÐ¹è";






        }

        public bool Cointoss(bool coin)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            int num = number % 2;

            bool result = (num == 1);

            return coin == result;
        }
    }
}



