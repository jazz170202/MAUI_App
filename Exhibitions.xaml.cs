
using CommunityToolkit.Maui.Views;
using System.ComponentModel;

namespace Course_prj;

public partial class Exhibitions : ContentPage
{
    public Exhibitions()
    {
    }

    public Exhibitions(ExhibitionsViewModel exhibitionsViewModel)
	{

		InitializeComponent();
        BindingContext = exhibitionsViewModel;

		
    
    }

   
}