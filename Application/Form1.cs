namespace Application;

public partial class Form1 : System.Windows.Forms.Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private void DisplayForm2Type1Button_Click(object sender, System.EventArgs e)
	{
		//Form2 myForm2 = new Form2();
		//myForm2.Show();

		//Form2 myForm2 = new();
		//myForm2.Show();

		//var myForm2 = new Form2();
		//myForm2.Show();

		//int temp = 1;

		var myForm2 = new Form2();

		// Step (2)
		myForm2.MyForm1 = this;

		myForm2.Show();
	}

	private void DisplayForm2Type2Button_Click(object sender, System.EventArgs e)
	{
		//var myForm2 = new Form2();
		//myForm2.ShowDialog();

		//int temp = 1;

		var myForm2 = new Form2();

		// Step (2)
		myForm2.MyForm1 = this;

		myForm2.ShowDialog();
	}
}
