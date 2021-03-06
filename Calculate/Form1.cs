﻿using System;
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
        /* 아니 생각해보니까 다중계산할때
         * x / 있으면 그거 먼저해야되는데 그거안함
         * 나중에 시간있으면 고쳐보기
         * 내생각엔 식을 한꺼번에 다 받아서 = 누르면 골라서
         * 차근차근 계산시켜야할듯 <stack 사용해보기>
         * 후위연산자 이용해서 해보기
         */

        private Double num1;
        private Double num2;
        private String temp;
        private String prev_temp;
        private int cnt;

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
            btn_0.Click += btn_num_clcik;
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
            
            // 만약 앞에 02 / 066 이라면 0 없애버리기
            if(result.Text.Length > 1 && result.Text.StartsWith("0"))
            {
                if (result.Text.Contains(".")) return;
                result.Text = result.Text.Remove(0, 1);
            }
        }

        private void btn_symbol_click1(object sender, EventArgs e)
        {
            /// 기호가 뭔지 저장
            Button btn = sender as Button;
            temp = btn.Text;
            // 현재 텍스트창 빈칸
            // - 누르면 부호 - 붙여주기
            // 나머지 기호 누르면 그냥 return
            if (result.Text == "")
            {
                if (temp.Equals("-"))
                {
                    result.Text += "-";
                }
                return;
            }
            // 현재 텍스트창에 있는 값 저장
            if (cnt < 1)
            {
                Double.TryParse(result.Text, out num1);
                prev_temp = temp;
                prev.Text += num1;
            }
            else 
            {
                Double.TryParse(result.Text, out num2);
                Console.WriteLine("num1 = {0} {2} num2 = {1}", num1, num2, prev_temp);
                num1 = multi_cal(num1, num2, prev_temp);
                prev.Text += num2;
            }

            // 숫자들 보여주기
            prev.Text += temp;
            result.Text = "0"; // 이거 지우고

            cnt++;
            prev_temp = temp;
        }

        private Double multi_cal(Double num1, Double num2, String prev_temp)
        {
            // 첫번째 클릭일때는 num1을 숫자 저장하는게 맞음
            // 첫번째에서 연산하면 num1 = num1 * num2 가 되는거임
            // 두번째에서 새로 입력된 값은 num2가 된다 (반복)
            Calculator cal = new Calculator();

            switch (prev_temp)
            {
                case "+":
                    result.Text = cal.plusResult(num1, num2).ToString();
                    return cal.plusResult(num1, num2);
                case "-":
                    result.Text = cal.minusResult(num1, num2).ToString();
                    return cal.minusResult(num1, num2);
                case "x":
                    result.Text = cal.multipleResult(num1, num2).ToString();
                    return cal.multipleResult(num1, num2);
                case "÷":
                    result.Text = cal.divideResult(num1, num2).ToString();
                    return cal.divideResult(num1, num2);
                default:
                    return 0;
            }
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            // = 버튼 눌렀을때의 결과
            num2 = Double.Parse(result.Text);
            // prev에 = 
            prev.Text += num2;
            prev.Text += "=";
            Calculator cal = new Calculator();

            // 그리고서 temp가 무엇인지 확인하기
            switch (temp)
            {
                case "+":
                    result.Text = cal.plusResult(num1, num2).ToString();
                    break;
                case "-":
                    result.Text = cal.minusResult(num1, num2).ToString();
                    break;
                case "x":
                    result.Text = cal.multipleResult(num1, num2).ToString();
                    break;
                case "÷":
                    result.Text = cal.divideResult(num1, num2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cal_clear();
        }

        private void cal_clear()
        {
            // CE 버튼 클릭시 텍스트박스 초기화
            result.Text = "0";
            prev.Text = "";
            num1 = 0;
            num2 = 0;
            temp = null;
            prev_temp = null;
            cnt = 0;
        }

    }
       
}
