namespace HelloPXL.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void OnMenu_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MenuPage));
    }

    private async void OnAbout_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AboutPage));
    }

}