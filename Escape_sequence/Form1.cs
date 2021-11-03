using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_sequence
{
    // $ {변수명} 으로 작업 가능하게 하는 거 
    // @ 이스케이프 시퀀스 안 써줘도 같은 기능 사용 가능하게 하는 거
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. 변수 입력 He is a Student   (tbox)
        private void btn1_Click(object sender, EventArgs e)
        {
            string str1 = tboxIs1.Text;
            string str2 = tboxIs2.Text;


            string strValue1 = string.Format("{0} is {1}",str1,str2);
            lboxStringFormat.Items.Add(strValue1);

            string strValue2 = $"{str1} is {str2}";   // $"{변수명} is {변수명}"
            lboxStringinterpolation.Items.Add(strValue2);
        }

        // 2. 현재 시간 표기    (dtPicker)
        private void btn2_Click(object sender, EventArgs e)
        {
            DateTime dt = dtPicker.Value;

            lboxStringFormat.Items.Add(string.Format("오늘은 {0:yyyy-mm-dd} 입니다.", dt));
            lboxStringinterpolation.Items.Add($"오늘은 {dt:yyyy-mm-dd} 입니다.");
        }


        // 3. 조건   (num1 , num2)
        private void btn3_Click(object sender, EventArgs e)
        {
            int i1 = (int)num1.Value;
            int i2 = (int)num2.Value;

            int iBig = (i1 > i2) ? i1 : i2;

            lboxStringFormat.Items.Add(string.Format("{0} 와 {1} 중에서 더 큰 수는 {2} 입니다.", i1, i2, iBig));
            lboxStringinterpolation.Items.Add($"{i1} 와 {i2} 중에서 더 큰 수는 {((i1 > i2 ) ? i1 : i2)} 입니다.");  //바로 조건식 작성 가능
        }


        // 4. 보간 문자 사용 {}
        //  {{{변수명}}} 하면 변수에 담겨있는 내용이 출력된다
        private void btn4_Click(object sender, EventArgs e)
        {
            string strValue = "str";

            lboxStringFormat.Items.Add(string.Format("{{{0}}}",strValue));    //str
            lboxStringinterpolation.Items.Add($"{{{strValue}}}");       //str
        }



        // 5. 단항식 사용
        private void btn5_Click(object sender, EventArgs e)
        {
            string strValue = tboxMono.Text;

            lboxStringFormat.Items.Add(string.Format("대문자 변환 {0}",strValue.ToUpper()));
            lboxStringinterpolation.Items.Add($"대문자 변환 {strValue.ToUpper()}");
        }


        // 6. 이스케이프 시퀀스(@)
        // \\ \r \n 같은 이스케이프 시퀀스 기능을 사용하고 싶을 때 @를 앞에 붙이면 이스케이프 시퀀스를 안적어줘도 적용 된다 
        private void btn6_Click(object sender, EventArgs e)
        {
            string strValue1 = "C\\User\\C#\\Escape_Sequence \r\n이스케이프 시퀀스 사용";
            string strValue2 = @"C\User\C\Escapte_Sequence
@로 사용";

            tboxEscape.Text = strValue1 + "\r\n\r\n" + strValue2;
        }


        // 7. 쿼리 표현식 ($@ 함께 사용)
        private void btn7_Click(object sender, EventArgs e)
        {
            string strQuery1 = "Test1";
            string strQuery2 = "Test2";


            /*   ""과 +를 너무 자주 써야하는 기존 방식 
            string Query1 = "Select " +
                            "From " +
                            "Where ";
            */


            string Query2 = $@"Select 
    Row1,Row2
 From
    DBTable
Where
    Row1 = {strQuery1}, Row2={strQuery2}";

            tboxQuery.Text = Query2;
        }
    }
}
