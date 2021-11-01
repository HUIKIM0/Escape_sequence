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
        private void btn4_Click(object sender, EventArgs e)
        {

        }



        // 5. 단항식 사용
        private void btn5_Click(object sender, EventArgs e)
        {

        }
    }
}
