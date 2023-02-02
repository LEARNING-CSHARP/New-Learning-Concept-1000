namespace Application
{
	partial class Form2
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
			this.changeMyTextBoxInForm1Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// changeMyTextBoxInForm1Button
			// 
			this.changeMyTextBoxInForm1Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.changeMyTextBoxInForm1Button.Location = new System.Drawing.Point(12, 12);
			this.changeMyTextBoxInForm1Button.Name = "changeMyTextBoxInForm1Button";
			this.changeMyTextBoxInForm1Button.Size = new System.Drawing.Size(344, 29);
			this.changeMyTextBoxInForm1Button.TabIndex = 0;
			this.changeMyTextBoxInForm1Button.Text = "Change My TextBox in Form 1";
			this.changeMyTextBoxInForm1Button.UseVisualStyleBackColor = true;
			this.changeMyTextBoxInForm1Button.Click += new System.EventHandler(this.ChangeMyTextBoxInForm1Button_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 317);
			this.Controls.Add(this.changeMyTextBoxInForm1Button);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button changeMyTextBoxInForm1Button;
	}
}