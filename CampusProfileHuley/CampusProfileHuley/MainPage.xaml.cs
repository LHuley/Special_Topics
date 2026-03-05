namespace CampusProfileHuley
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            await DisplayAlert(
                "Tip", "When traversing the campus, be sure to use the maps along across the area so that you don't loss your way.", "OK");

        }
        private async void NextOnClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NewPage1));
        }
    }

}
