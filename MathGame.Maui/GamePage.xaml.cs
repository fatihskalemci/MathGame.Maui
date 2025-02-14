namespace MathGame.Maui;

public partial class GamePage : ContentPage
{
	public string GameType { get; set; }
	public GamePage(string gameType)
	{
		InitializeComponent();
		GameType = gameType;
		BindingContext = this;
	}

	private void CreateNewQuestion()
	{
		var gameOperator = GameType switch
		{
			"Addition" => "+",
			"Subtraction" => "-",
			"Multipllication" => "*",
			"Division" => "/",
			_ => ""
		};
	}
}