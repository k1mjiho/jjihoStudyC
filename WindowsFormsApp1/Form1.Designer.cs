
namespace WindowsFormsApp1
{
    partial class lblContaim
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblContain = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.lblTolower = new System.Windows.Forms.Label();
            this.lblToupper = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.lblSplit3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(55, 47);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(132, 15);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Sample, Test, Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Replace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Equals";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Substring";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "ToUpper";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "ToLower";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Split";
            // 
            // lblContain
            // 
            this.lblContain.AutoSize = true;
            this.lblContain.Location = new System.Drawing.Point(143, 96);
            this.lblContain.Name = "lblContain";
            this.lblContain.Size = new System.Drawing.Size(15, 15);
            this.lblContain.TabIndex = 11;
            this.lblContain.Text = "-";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(143, 140);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(15, 15);
            this.lblEquals.TabIndex = 12;
            this.lblEquals.Text = "-";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(143, 183);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(15, 15);
            this.lblLength.TabIndex = 13;
            this.lblLength.Text = "-";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(143, 228);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(15, 15);
            this.lblReplace.TabIndex = 14;
            this.lblReplace.Text = "-";
            // 
            // lblSplit1
            // 
            this.lblSplit1.AutoSize = true;
            this.lblSplit1.Location = new System.Drawing.Point(143, 271);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(15, 15);
            this.lblSplit1.TabIndex = 15;
            this.lblSplit1.Text = "-";
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Location = new System.Drawing.Point(412, 97);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(15, 15);
            this.lblSubstring.TabIndex = 16;
            this.lblSubstring.Text = "-";
            // 
            // lblTolower
            // 
            this.lblTolower.AutoSize = true;
            this.lblTolower.Location = new System.Drawing.Point(412, 140);
            this.lblTolower.Name = "lblTolower";
            this.lblTolower.Size = new System.Drawing.Size(15, 15);
            this.lblTolower.TabIndex = 17;
            this.lblTolower.Text = "-";
            // 
            // lblToupper
            // 
            this.lblToupper.AutoSize = true;
            this.lblToupper.Location = new System.Drawing.Point(412, 183);
            this.lblToupper.Name = "lblToupper";
            this.lblToupper.Size = new System.Drawing.Size(15, 15);
            this.lblToupper.TabIndex = 18;
            this.lblToupper.Text = "-";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(412, 228);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(15, 15);
            this.lblTrim.TabIndex = 19;
            this.lblTrim.Text = "-";
            // 
            // lblSplit2
            // 
            this.lblSplit2.AutoSize = true;
            this.lblSplit2.Location = new System.Drawing.Point(143, 315);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(15, 15);
            this.lblSplit2.TabIndex = 20;
            this.lblSplit2.Text = "-";
            // 
            // lblSplit3
            // 
            this.lblSplit3.AutoSize = true;
            this.lblSplit3.Location = new System.Drawing.Point(143, 358);
            this.lblSplit3.Name = "lblSplit3";
            this.lblSplit3.Size = new System.Drawing.Size(15, 15);
            this.lblSplit3.TabIndex = 21;
            this.lblSplit3.Text = "-";
            // 
            // lblContaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 512);
            this.Controls.Add(this.lblSplit3);
            this.Controls.Add(this.lblSplit2);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblToupper);
            this.Controls.Add(this.lblTolower);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.lblSplit1);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblContain);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.Name = "lblContaim";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblContain;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.Label lblTolower;
        private System.Windows.Forms.Label lblToupper;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Label lblSplit2;
        private System.Windows.Forms.Label lblSplit3;
    }
}

