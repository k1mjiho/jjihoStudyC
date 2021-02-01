using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lblContaim : Form
    {
        public lblContaim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 실행버튼을 클릭했을 때 실행되는 메소드
            String strText = lblText.Text;

            lblContain.Text = strText.Contains("Tit").ToString(); // 문자열로반환
            lblEquals.Text = strText.Equals("Test").ToString();
            lblLength.Text = strText.Length.ToString();
            lblReplace.Text = strText.Replace("Test", "I can").ToString();

            string[] strSplit = strText.Split(',');
            lblSplit1.Text = strSplit[0].ToString();
            lblSplit2.Text = strSplit[1].ToString();
            lblSplit3.Text = strSplit[2].ToString();

            lblSubstring.Text = strText.Substring(3, 5).ToString();
            lblTolower.Text = strText.ToLower();
            lblToupper.Text = strText.ToUpper();
            lblTrim.Text = strText.Trim();
        }
    }
}
