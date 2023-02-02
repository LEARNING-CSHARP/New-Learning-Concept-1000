namespace Application;

internal static class Program
{
	[System.STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();
		System.Windows.Forms.Application.Run(new Form1());
	}
}
