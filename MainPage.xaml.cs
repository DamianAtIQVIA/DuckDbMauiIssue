using DuckDB.NET.Data;

namespace DuckDbMauiIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	async  void OnCounterClicked(object sender, EventArgs e)
	{
		using var con = new DuckDBConnection($"Data Source=example.db");
		try
		{
			await con.OpenAsync();
			ExceptionLabel.Text = "Success. No exception.";
		}
		catch (Exception exception)
		{
			Console.WriteLine(exception);
			ExceptionLabel.Text = exception.ToString();
		}
	}
}

