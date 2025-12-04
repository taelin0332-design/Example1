namespace solution1
{
    public partial class Form1 : Form
    {
            public Form1()
            {
                InitializeComponent();

                string[] array = new string[10];

                string str1 = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";

                int index1 = str1.IndexOf(". -");
                array[0] = index1.ToString();

                int pos = str1.LastIndexOf(" -공자");
                string index2 = str1.Remove(pos, "-공자".Length);
                array[1] = index2;

                string index3 = str1.Replace(".", ",");
                array[2] = index3.ToString();

                string index4 = array[2].Replace("-", ",");
                array[3] = index4.ToString();

                int index5 = str1.IndexOf("얼마나");
                array[4] = index5.ToString();

                int index6 = str1.IndexOf("천천히");
                array[5] = index6.ToString();

                int index7 = str1.IndexOf("가는지");
                array[6] = index7.ToString();

                string[] parts = "얼마나 천천히 가는지".Split(" ");
                array[7] = parts[0].Trim();
                array[8] = parts[1].Trim();
                array[9] = parts[2].Trim();



                foreach (var item in array)
                {
                    textBox1.Text += item + "\r\n";
                }





        }
    }
}
