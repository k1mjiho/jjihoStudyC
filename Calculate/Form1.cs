using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculate;

namespace Calculate
{
    public partial class Form1 : Form
    {
        Double num1;
        Double num2;
        String temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 처음 로드 될 때 시작되는 함수
            btn_1.Click += btn_num_clcik;
            btn_2.Click += btn_num_clcik;
            btn_3.Click += btn_num_clcik;
            btn_4.Click += btn_num_clcik;
            btn_5.Click += btn_num_clcik;
            btn_6.Click += btn_num_clcik;
            btn_7.Click += btn_num_clcik;
            btn_8.Click += btn_num_clcik;
            btn_9.Click += btn_num_clcik;
            btn_point.Click += btn_num_clcik;

            btn_plus.Click += btn_symbol_click1;
            btn_minus.Click += btn_symbol_click1;
            btn_multiple.Click += btn_symbol_click1;
            btn_divide.Click += btn_symbol_click1;
        }

        private void btn_num_clcik(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string name = btn.Name;

            // 버튼 클릭시 해당 버튼값 가져와서 텍스트창에 보여주기
            result.Text += btn.Text;

        }

        private void btn_symbol_click1(object sender, EventArgs e)
        {
            Console.WriteLine(result.Text);
            num1 = Double.Parse(result.Text);
            // 현재 텍스트창에 있는 값 저장
            /// 기호가 뭔지 저장
            Button btn = sender as Button;
            temp = btn.Text;
            Console.Write(temp);
            result.Text = "";

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            // = 버튼 눌렀을때의 결과
            num2 = Double.Parse(result.Text);
            Console.Write(num1);
            Console.Write(temp);
            Console.Write(num2);
            Calculator cal = new Calculator();

            // 그리고서 temp가 무엇인지 확인하기
            switch (temp)
            {
                case "+":
                    result.Text = cal.plusResult(num1, num2).ToString();
                    break;
                case "-":
                    cal.minusResult(num1, num2);
                    break;
                case "x":
                    cal.multipleResult(num1, num2);
                    break;
                case "/":
                    cal.divideResult(num1, num2);
                    break;
                default:
                    break;
            }
            //  마지막에 다시 temp, num1, num2 초기화
            cal_clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cal_clear();
        }

        private void cal_clear()
        {
            // CE 버튼 클릭시 텍스트박스 초기화
            result.Text = "";
            num1 = 0;
            num2 = 0;
            temp = null;
        }
    }
       
}
