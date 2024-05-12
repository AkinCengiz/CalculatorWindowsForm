namespace CalculatorWindowsForm
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbxScreen = new System.Windows.Forms.GroupBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDot = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnBackspace = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnResult = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnSubtract = new System.Windows.Forms.Button();
			this.gbxScreen.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxScreen
			// 
			this.gbxScreen.Controls.Add(this.lblResult);
			this.gbxScreen.Controls.Add(this.txtNumber);
			this.gbxScreen.Location = new System.Drawing.Point(12, 12);
			this.gbxScreen.Name = "gbxScreen";
			this.gbxScreen.Size = new System.Drawing.Size(563, 188);
			this.gbxScreen.TabIndex = 0;
			this.gbxScreen.TabStop = false;
			this.gbxScreen.Text = "Dijital Gösterge";
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblResult.Location = new System.Drawing.Point(6, 101);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(68, 73);
			this.lblResult.TabIndex = 1;
			this.lblResult.Text = "0";
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNumber
			// 
			this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtNumber.Location = new System.Drawing.Point(7, 30);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(541, 62);
			this.txtNumber.TabIndex = 0;
			this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDot);
			this.groupBox1.Controls.Add(this.btn0);
			this.groupBox1.Controls.Add(this.btn3);
			this.groupBox1.Controls.Add(this.btn2);
			this.groupBox1.Controls.Add(this.btn1);
			this.groupBox1.Controls.Add(this.btn6);
			this.groupBox1.Controls.Add(this.btn5);
			this.groupBox1.Controls.Add(this.btn4);
			this.groupBox1.Controls.Add(this.btn9);
			this.groupBox1.Controls.Add(this.btn8);
			this.groupBox1.Controls.Add(this.btn7);
			this.groupBox1.Location = new System.Drawing.Point(13, 206);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(329, 462);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Numerik Tuşlar";
			// 
			// btnDot
			// 
			this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDot.Location = new System.Drawing.Point(218, 348);
			this.btnDot.Name = "btnDot";
			this.btnDot.Size = new System.Drawing.Size(100, 100);
			this.btnDot.TabIndex = 11;
			this.btnDot.Text = ",";
			this.btnDot.UseVisualStyleBackColor = true;
			this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn0.Location = new System.Drawing.Point(6, 348);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(206, 100);
			this.btn0.TabIndex = 10;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			// 
			// btn3
			// 
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn3.Location = new System.Drawing.Point(218, 242);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(100, 100);
			this.btn3.TabIndex = 8;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn2.Location = new System.Drawing.Point(112, 242);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(100, 100);
			this.btn2.TabIndex = 7;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn1.Location = new System.Drawing.Point(6, 242);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(100, 100);
			this.btn1.TabIndex = 6;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn6
			// 
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn6.Location = new System.Drawing.Point(218, 136);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(100, 100);
			this.btn6.TabIndex = 5;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btn5
			// 
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn5.Location = new System.Drawing.Point(112, 136);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(100, 100);
			this.btn5.TabIndex = 4;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn4
			// 
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn4.Location = new System.Drawing.Point(6, 136);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(100, 100);
			this.btn4.TabIndex = 4;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// btn9
			// 
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn9.Location = new System.Drawing.Point(218, 30);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(100, 100);
			this.btn9.TabIndex = 2;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.btn9_Click);
			// 
			// btn8
			// 
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn8.Location = new System.Drawing.Point(112, 30);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(100, 100);
			this.btn8.TabIndex = 1;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.btn8_Click);
			// 
			// btn7
			// 
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn7.Location = new System.Drawing.Point(6, 30);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(100, 100);
			this.btn7.TabIndex = 0;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.btn7_Click);
			// 
			// btnMultiply
			// 
			this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMultiply.Location = new System.Drawing.Point(6, 242);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(100, 100);
			this.btnMultiply.TabIndex = 9;
			this.btnMultiply.Text = "*";
			this.btnMultiply.UseVisualStyleBackColor = true;
			this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnBackspace);
			this.groupBox2.Controls.Add(this.btnReset);
			this.groupBox2.Controls.Add(this.btnResult);
			this.groupBox2.Controls.Add(this.btnPlus);
			this.groupBox2.Controls.Add(this.btnDivide);
			this.groupBox2.Controls.Add(this.btnSubtract);
			this.groupBox2.Controls.Add(this.btnMultiply);
			this.groupBox2.Location = new System.Drawing.Point(348, 206);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(227, 462);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Aritmetik Tuşlar";
			// 
			// btnBackspace
			// 
			this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBackspace.Location = new System.Drawing.Point(6, 30);
			this.btnBackspace.Name = "btnBackspace";
			this.btnBackspace.Size = new System.Drawing.Size(100, 100);
			this.btnBackspace.TabIndex = 17;
			this.btnBackspace.Text = "<-";
			this.btnBackspace.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnReset.Location = new System.Drawing.Point(112, 30);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(100, 100);
			this.btnReset.TabIndex = 16;
			this.btnReset.Text = "C";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnResult
			// 
			this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnResult.Location = new System.Drawing.Point(112, 242);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(100, 206);
			this.btnResult.TabIndex = 15;
			this.btnResult.Text = "=";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPlus.Location = new System.Drawing.Point(6, 348);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(100, 100);
			this.btnPlus.TabIndex = 14;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnDivide
			// 
			this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDivide.Location = new System.Drawing.Point(6, 136);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(100, 100);
			this.btnDivide.TabIndex = 13;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = true;
			this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
			// 
			// btnSubtract
			// 
			this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSubtract.Location = new System.Drawing.Point(112, 136);
			this.btnSubtract.Name = "btnSubtract";
			this.btnSubtract.Size = new System.Drawing.Size(100, 100);
			this.btnSubtract.TabIndex = 10;
			this.btnSubtract.Text = "-";
			this.btnSubtract.UseVisualStyleBackColor = true;
			this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(584, 682);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxScreen);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxScreen.ResumeLayout(false);
			this.gbxScreen.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxScreen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnDot;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btnResult;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnSubtract;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnBackspace;
	}
}

