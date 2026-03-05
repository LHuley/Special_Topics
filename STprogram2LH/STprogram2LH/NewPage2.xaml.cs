namespace STprogram2LH;

public partial class NewPage2 : ContentPage
{
    int count = 0;
    int count1 = 0;
    public NewPage2()
	{
		InitializeComponent();
	}
    private async void OnActionButtonClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 2)
            await DisplayAlert("Attraction Info", "Located in Atlanta, Georgia, Stone Mountain Park is deemed to be Georgia's most popular attraction. Its centerpiece is the world's largest exposed granite dome.", "OK");

        if (count == 2)
            count = 0;

    }
    private async void OnActionButtonClicked1(object sender, EventArgs e)
    {
        count1++;

        if (count1 == 2)
            await DisplayAlert("Attraction Info", "Located in Savannah, Georgia, Forsyth Park is an iconic 30-acre public park that resides in the historic district. Its signature fountain was contructed all the way in 1858 and has underwent major restoration as of 2025.", "OK");

        if (count1 == 2)
            count1 = 0;

    }
    private async void OnGoToFirstpage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
    private async void GoToFoodPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewPage1));
    }
}