namespace Ramirez_TareaMVVM.Views;

public partial class WRAboutPage : ContentPage
{
	public WRAboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.WRAbout about)
        {
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}