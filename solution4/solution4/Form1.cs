namespace solution4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public bool Cointoss(bool coin)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            int num = number % 2;

            bool result = (num == 1);

            return coin == result;
        }

        private void button_Input_Click(object sender, EventArgs e)
        {
            bool userChoice;
            string input = textBox_Input.Text.Trim();

            // 1. 사용자가 true/false 입력한 경우 (우선 처리)
            if (!string.IsNullOrEmpty(input))
            {
                if (!bool.TryParse(input, out userChoice))
                {
                    textBox_result.Text = "true 또는 false만 입력하세요.";
                    return;
                }
            }
            else
            {
                // 2. textBox_input이 비었으면 라디오 버튼 상태 사용
                if (radioTrue.Checked)
                {
                    userChoice = true;
                }
                else if (radioFalse.Checked)
                {
                    userChoice = false;
                }
                else
                {
                    textBox_result.Text = "true/false를 입력하거나 선택하세요.";
                    return;
                }
            }

            // 3. 동전 던지기 실행
            bool game = Cointoss(userChoice);

            // 4. 결과 출력
            textBox_result.Text = game ? "승리" : "패배";
        }

        private void radioFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioTrue_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
