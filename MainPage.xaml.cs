namespace Course_prj
{
    public partial class MainPage : ContentPage
    {

        bool istapped;
        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gallery());
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            
            lblOverlay.Text = "Pieta by Michelangelo";
            lblOverlay.TextColor = Colors.White;
            lblOverlay.FontSize = 15;
        }
    }

}
