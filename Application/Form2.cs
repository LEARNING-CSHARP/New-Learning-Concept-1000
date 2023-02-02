namespace Application;

public partial class Form2 : System.Windows.Forms.Form
{
	public Form2()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Step (1)
	/// </summary>
	public Form1 MyForm1 { get; set; }

	private void ChangeMyTextBoxInForm1Button_Click(object sender, System.EventArgs e)
	{
		MyForm1.myTextBox.Text = "Hello, World!";
	}
}
