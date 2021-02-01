using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsrt_Click(object sender, EventArgs e)
        {
            try
            {
                // tboxNumber.Text 텍스트박스에서 가져온 넘버
                short sNumber = short.Parse(tboxNumber.Text); // 3만2천 어쩌구까지만 표현가능

                lblSort.Text = sNumber.ToString();
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnint_Click(object sender, EventArgs e)
        {
            try
            {
                // tboxNumber.Text 텍스트박스에서 가져온 넘버
                int sNumber = int.Parse(tboxNumber.Text); // 3만2천 어쩌구까지만 표현가능

                lblInt.Text = sNumber.ToString();
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btndouble_Click(object sender, EventArgs e)
        {
            try
            {
                // tboxNumber.Text 텍스트박스에서 가져온 넘버
                Double sNumber = double.Parse(tboxNumber.Text); // 3만2천 어쩌구까지만 표현가능

                lblDouble.Text = sNumber.ToString();
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;

            if(short.TryParse(tboxNumber.Text,out sNumber)) // 가능하다면 short형으로 바꿔주고 sNumber로 받는다(out) 자체로는  t/f 로 반환
            {
                lblSort.Text = sNumber.ToString();
            }
            else if(int.TryParse(tboxNumber.Text,out iNumber))
            {
                lblInt.Text = iNumber.ToString();
            }
            else if(double.TryParse(tboxNumber.Text,out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
            }
            else
            {
                lblException.Text = "변환 할 수 없음"; 
            }
        }
    }
}
