namespace TheChronicle.View;

public partial class Shop : ContentPage
{
	public Shop()
	{
		InitializeComponent();
	}


    private async void GoToVillageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Village());
    }
}