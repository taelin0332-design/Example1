using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace solution6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        public enum Days
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

            if (Enum.TryParse(textBox_input.Text, out Days today))
            {

                switch (today)
                {
                    case Days.Sunday:
                        textBox_result.Text = "일요일입니다.";
                        break;

                    case Days.Monday:
                        textBox_result.Text = "월요일입니다.";
                        break;

                    case Days.Tuesday:
                        textBox_result.Text = "화요일입니다.";
                        break;

                    case Days.Wednesday:
                        textBox_result.Text = "수요일입니다.";
                        break;

                    case Days.Thursday:
                        textBox_result.Text = "목요일입니다.";
                        break;

                    case Days.Friday:
                        textBox_result.Text = "금요일입니다.";
                        break;

                    case Days.Saturday:
                        textBox_result.Text = "토요일입니다.";
                        break;


                }
            }
            else
            {
                // 변환 실패 → 잘못된 입력
                textBox_result.Text = "요일 이름을 정확히 입력하세요 (Sunday ~ Saturday)";
            }


        }
    }
}
