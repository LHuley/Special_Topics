namespace CampusProfileHuley;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void OnCheerClicked(object? sender, EventArgs e)
    {
        await DisplayAlert(
            "Cheers", "Hooray!!!", "OK");

    }

    private async void BackOnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}