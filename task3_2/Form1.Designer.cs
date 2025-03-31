namespace task3_2
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
            txtBase = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtExponent = new TextBox();
            btnCalculate = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblResult = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(85, 15);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(150, 23);
            txtBase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 57);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Exponent:";
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(85, 54);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(150, 23);
            txtExponent.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(97, 108);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBase);
            panel1.Controls.Add(btnCalculate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtExponent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 157);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblResult);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 52);
            panel2.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(17, 12);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 209);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Power Calculation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBase;
        private Label label1;
        private Label label2;
        private TextBox txtExponent;
        private Button btnCalculate;
        private Panel panel1;
        private Panel panel2;
        private Label lblResult;
    }
}
