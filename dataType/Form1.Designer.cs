
namespace dataType
{
    partial class Form1
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
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.btnsrt = new System.Windows.Forms.Button();
            this.btnint = new System.Windows.Forms.Button();
            this.btndouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(12, 12);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(789, 25);
            this.tboxNumber.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "알아서 변환";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exception";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(200, 87);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(15, 15);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(200, 149);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(15, 15);
            this.lblInt.TabIndex = 7;
            this.lblInt.Text = "0";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(200, 207);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(15, 15);
            this.lblDouble.TabIndex = 8;
            this.lblDouble.Text = "0";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(200, 264);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(15, 15);
            this.lblException.TabIndex = 9;
            this.lblException.Text = "-";
            // 
            // btnsrt
            // 
            this.btnsrt.Location = new System.Drawing.Point(358, 81);
            this.btnsrt.Name = "btnsrt";
            this.btnsrt.Size = new System.Drawing.Size(98, 25);
            this.btnsrt.TabIndex = 10;
            this.btnsrt.Text = "Short 변환";
            this.btnsrt.UseVisualStyleBackColor = true;
            this.btnsrt.Click += new System.EventHandler(this.btnsrt_Click);
            // 
            // btnint
            // 
            this.btnint.Location = new System.Drawing.Point(358, 139);
            this.btnint.Name = "btnint";
            this.btnint.Size = new System.Drawing.Size(98, 25);
            this.btnint.TabIndex = 11;
            this.btnint.Text = "Int 변환";
            this.btnint.UseVisualStyleBackColor = true;
            this.btnint.Click += new System.EventHandler(this.btnint_Click);
            // 
            // btndouble
            // 
            this.btndouble.Location = new System.Drawing.Point(358, 197);
            this.btndouble.Name = "btndouble";
            this.btndouble.Size = new System.Drawing.Size(98, 25);
            this.btndouble.TabIndex = 12;
            this.btndouble.Text = "Double 변환";
            this.btndouble.UseVisualStyleBackColor = true;
            this.btndouble.Click += new System.EventHandler(this.btndouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 505);
            this.Controls.Add(this.btndouble);
            this.Controls.Add(this.btnint);
            this.Controls.Add(this.btnsrt);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tboxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Button btnsrt;
        private System.Windows.Forms.Button btnint;
        private System.Windows.Forms.Button btndouble;
    }
}

