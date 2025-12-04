namespace solution2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var (num1, num2) = ReadTwonum();

            MessageBox.Show($"Number 1: {num1}, Number 2: {num2}");
            int result = Divide(num1, num2);

            int remain = Remain(num1, num2);
           
            int[] array = new int[5];
            array[0] = result;
            array[1] = remain;
            MessageBox.Show($"나누기 값: {array[0]}, 나머지 값: {array[1]}");




        }

        public (int, int) ReadTwonum() // 숫자 입력 받기
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            return (num1, num2);
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;

        }

        public int Remain(int num1, int num2)
            {
            return num1 % num2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
