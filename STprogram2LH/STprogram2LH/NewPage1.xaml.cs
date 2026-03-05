namespace STprogram2LH;

public partial class NewPage1 : ContentPage
{
	int count = 0;
    int count1 = 0;
    int count2 = 0;
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void OnActionButtonClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 2)
            await DisplayAlert("Restaurant Info", "Located in Savannah, Georgia and holding a rating 4.7 stars, Leopold's Ice Cream provides high-quality and creamy ice cream for its customers. It is even rated as one of the top 10 indie ice cream shops in the U.S.", "OK");
        
        if (count == 2)
            count = 0;   

    }
    private async void OnActionButtonClicked1(object sender, EventArgs e)
    {
        count1++;

        if (count1 == 2)
            await DisplayAlert("Restaurant Info", "Located in Atlanta, Georgia with a rating of 4.3 stars, This historic diner is widely known for its class southern breakfast meals. Parking space often becomes scarce quickly, so make sure you arrive early!", "OK");

        if (count1 == 2)
            count1 = 0;

    }
    private async void OnActionButtonClicked2(object sender, EventArgs e)
    {
        count2++;

        if (count2 == 2)
            await DisplayAlert("Restaurant Info", "Located in Blue Ridge, Georgia with a rating of 4.5 stars, Mercier Orchards contains more that 100,000 trees and is well known for its well-pressed cider and apple pies. Sometimes it's even ranked as the #1 apple orchard in the U.S.", "OK");

        if (count2 == 2)
            count2 = 0;

    }
    private async void OnGoToFirstpage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
    private async void GoToTourPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewPage2));
    }
}