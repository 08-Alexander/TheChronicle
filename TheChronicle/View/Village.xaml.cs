namespace TheChronicle.View
{
    public partial class Village : ContentPage
    {
        public Village()
        {
            InitializeComponent();
        }

        private void ChangeNameOnVillageClicked(object? sender, EventArgs e)
        {
            MinByLabel.Text = "Göteborg";
        }

        private async void GoToShopClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shop());
        }
    }
}
