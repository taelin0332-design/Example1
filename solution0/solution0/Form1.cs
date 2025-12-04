namespace solution0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte studentCount = 30;
            short buildingFloor = 15;
            int cityPopulation = 950000;
            float itemPrice = 19.99f;
            double rocketPressure = 0.0001234567;
            decimal nationalDebt = 1234567890.12m;

            textBox1.Text += studentCount;
            textBox1.Text += "\r\n";
            textBox1.Text += studentCount.GetType();
            textBox1.Text += "\r\n";

            textBox1.Text += buildingFloor.ToString();
            textBox1.Text += "\r\n";
            textBox1.Text += buildingFloor.GetType();
            textBox1.Text += "\r\n";

            textBox1.Text += cityPopulation.ToString();
            textBox1.Text += "\r\n";
            textBox1.Text += cityPopulation.GetType();
            textBox1.Text += "\r\n";

            textBox1.Text += itemPrice.ToString();
            textBox1.Text += "\r\n";
            textBox1.Text += itemPrice.GetType();
            textBox1.Text += "\r\n";

            textBox1.Text += rocketPressure.ToString();
            textBox1.Text += "\r\n";
            textBox1.Text += rocketPressure.GetType();
            textBox1.Text += "\r\n";

            textBox1.Text += nationalDebt.ToString();
            textBox1.Text += "\r\n";
            textBox1.Text += nationalDebt.GetType();

        }
    }
}
