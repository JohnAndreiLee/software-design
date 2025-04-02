namespace lab3
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
            btnDisplay = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(178, 314);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(88, 29);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(24, 25);
            listBox.Name = "listBox";
            listBox.Size = new Size(420, 259);
            listBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 368);
            Controls.Add(listBox);
            Controls.Add(btnDisplay);
            Name = "Form1";
            Text = "Bookstore System";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
        private ListBox listBox;
    }
}
