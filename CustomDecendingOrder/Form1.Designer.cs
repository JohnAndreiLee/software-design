namespace BubbleSort
{
    partial class CustomDecendingOrderForm
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
            panel1 = new Panel();
            textBoxValues = new TextBox();
            label3 = new Label();
            label2 = new Label();
            buttonGenerate = new Button();
            buttonSort = new Button();
            label1 = new Label();
            panel2 = new Panel();
            listBox = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxValues);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonGenerate);
            panel1.Controls.Add(buttonSort);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // textBoxValues
            // 
            textBoxValues.Location = new Point(109, 100);
            textBoxValues.Name = "textBoxValues";
            textBoxValues.Size = new Size(74, 23);
            textBoxValues.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 103);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "No. of values:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 3;
            label2.Text = "Generate random values:";
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(47, 140);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(104, 47);
            buttonGenerate.TabIndex = 2;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(47, 293);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(104, 47);
            buttonSort.TabIndex = 1;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 0;
            label1.Text = "Custom Decending Order Demo";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(listBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 450);
            panel2.TabIndex = 1;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(27, 29);
            listBox.Name = "listBox";
            listBox.Size = new Size(542, 394);
            listBox.TabIndex = 0;
            // 
            // CustomDecendingOrderForm
            // 
            AcceptButton = buttonGenerate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomDecendingOrderForm";
            Text = "Custom Decending Order";
            Load += BubbleSortForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button buttonGenerate;
        private Button buttonSort;
        private Label label1;
        private Panel panel2;
        private TextBox textBoxValues;
        private Label label3;
        private ListBox listBox;
    }
}
