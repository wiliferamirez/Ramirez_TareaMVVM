namespace Ramirez_TareaMVVM.Views;

public partial class WRAboutPage : ContentPage
{
	public WRAboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}