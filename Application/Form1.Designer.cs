namespace Application
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
			this.displayForm2Type1Button = new System.Windows.Forms.Button();
			this.displayForm2Type2Button = new System.Windows.Forms.Button();
			this.myTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// displayForm2Type1Button
			// 
			this.displayForm2Type1Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayForm2Type1Button.Location = new System.Drawing.Point(12, 12);
			this.displayForm2Type1Button.Name = "displayForm2Type1Button";
			this.displayForm2Type1Button.Size = new System.Drawing.Size(382, 29);
			this.displayForm2Type1Button.TabIndex = 0;
			this.displayForm2Type1Button.Text = "Display Form 2 Type &1";
			this.displayForm2Type1Button.UseVisualStyleBackColor = true;
			this.displayForm2Type1Button.Click += new System.EventHandler(this.DisplayForm2Type1Button_Click);
			// 
			// displayForm2Type2Button
			// 
			this.displayForm2Type2Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayForm2Type2Button.Location = new System.Drawing.Point(12, 47);
			this.displayForm2Type2Button.Name = "displayForm2Type2Button";
			this.displayForm2Type2Button.Size = new System.Drawing.Size(382, 29);
			this.displayForm2Type2Button.TabIndex = 1;
			this.displayForm2Type2Button.Text = "Display Form 2 Type &2";
			this.displayForm2Type2Button.UseVisualStyleBackColor = true;
			this.displayForm2Type2Button.Click += new System.EventHandler(this.DisplayForm2Type2Button_Click);
			// 
			// myTextBox
			// 
			this.myTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.myTextBox.Location = new System.Drawing.Point(12, 82);
			this.myTextBox.Name = "myTextBox";
			this.myTextBox.Size = new System.Drawing.Size(382, 27);
			this.myTextBox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 123);
			this.Controls.Add(this.myTextBox);
			this.Controls.Add(this.displayForm2Type2Button);
			this.Controls.Add(this.displayForm2Type1Button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button displayForm2Type1Button;
		private System.Windows.Forms.Button displayForm2Type2Button;

		/// <summary>
		/// Step (3)
		/// </summary>
		public System.Windows.Forms.TextBox myTextBox;
	}
}
