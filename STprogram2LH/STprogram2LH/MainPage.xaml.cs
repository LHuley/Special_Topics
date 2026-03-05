namespace STprogram2LH
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                FoodBtn.Text = $"Clicked {count} time";
            else
                FoodBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(FoodBtn.Text);
        }

        private async void GoToFoodPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NewPage1));
        }
        private async void GoToTourPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NewPage2));
        }
    }

}
