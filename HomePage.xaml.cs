namespace Course_prj;

public partial class HomePage : ContentPage
{
	int tapCount = 0;
	public HomePage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		tapCount++;
		if (tapCount%2==0)
		{
			favourite.Source = "starfilled.svg";
			favourite.HeightRequest = 25;
		}
		else
		{
			favourite.Source = "star.svg";
		}

    }
}