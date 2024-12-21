namespace Course_prj;

public partial class Gallery : ContentPage
{
	public Gallery()
	{
		InitializeComponent();
	}

    private async void Woman_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());

    }

    private async void Greek_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Greek());
    }

    private async void exhibit_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Exhibitions());
    }

    
}