namespace lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSolve = new Button();
            textBoxInput = new TextBox();
            label1 = new Label();
            labelResult = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new Point(46, 106);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(75, 23);
            buttonSolve.TabIndex = 0;
            buttonSolve.Text = "Solve";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click_1;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(33, 60);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 68);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Result:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(166, 93);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxInput);
            panel1.Controls.Add(labelResult);
            panel1.Controls.Add(buttonSolve);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 167);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 21);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Recursive Factorial";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSumResult);
            panel2.Controls.Add(btnCalculateSum);
            panel2.Controls.Add(txtArrayInput);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 228);
            panel2.TabIndex = 5;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(33, 159);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(0, 15);
            lblSumResult.TabIndex = 8;
            lblSumResult.Click += lblCalculateSum_Click;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(46, 109);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(75, 23);
            btnCalculateSum.TabIndex = 7;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(33, 68);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(175, 23);
            txtArrayInput.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 32);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 5;
            label3.Text = "Sum of Array Elements";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 395);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSolve;
        private TextBox textBoxInput;
        private Label label1;
        private Label labelResult;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label lblSumResult;
        private Button btnCalculateSum;
        private TextBox txtArrayInput;
    }
}
