namespace solution_0_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] array = new string[10];

            // 1. IndexOf
            int index1 = "동해 물과 백두산이".IndexOf("백두산");
            array[0] = index1.ToString();

            // 2. LastIndexOf
            int index2 = "토요일에 먹는 토마토".LastIndexOf("토");
            array[1] = index2.ToString();

            // 3. Contains
            bool index3 = "질서 있는 퇴장".Contains("퇴");
            array[2] = index3.ToString();

            // 4. Replace
            string index4 = "그 사람의 그림자는 그랬다.".Replace("그", "이");
            array[3] = index4;

            // 5. Insert (삼성[0~1] 이후 공백 포함)
            string index5 = "삼성 갤럭시".Insert(2, " 애플");
            array[4] = index5;

            // 6. Remove 
            string str6 = "오늘은 왠지 더 배고프다";
            int pos = str6.IndexOf("더");
            string index6 = str6.Remove(pos, "더".Length);
            array[5] = index6;

            // 7. Split (이건 3칸 사용)
            string[] parts = "이름, 나이, 전화번호".Split(',');
            array[6] = parts[0].Trim();
            array[7] = parts[1].Trim();
            array[8] = parts[2].Trim();

            // 8. Substring ("나라"만 꺼내기)
            string str8 = "우리 나라 만세";
            int start = str8.IndexOf("나라");
            string index8 = str8.Substring(start, "나라".Length);
            array[9] = index8;

            // 9. TextBox 출력
            foreach (var item in array)
            {
                textBox1.Text += item + "\r\n";
            }
        }
    }
}
    
