namespace TheChronicle.View;

public partial class StartMenu : ContentPage
{
	public StartMenu()
	{
		InitializeComponent();
	}


    private async void StartGameClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Village());
    }
}