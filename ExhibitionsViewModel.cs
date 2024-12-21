using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Course_prj
{
    public partial class ExhibitionsViewModel:ObservableObject
    {
        public ObservableCollection<CarouselItem> CarouselItems { get; set; } = new();

        public ExhibitionsViewModel()
        {
            CarouselItems.Add(new CarouselItem()
            {
                Title = "Ancient Greece",
                Description = "Dive into the world of antiquities and ancient Greek philosophs until February 2025",
                Image = "greekvase.png"

            });
            CarouselItems.Add(new CarouselItem()
            {
                Title = "Ancient Egypt",
                Description = "The unbelieveable world of Egyptian gods and godesses, now displayed in Art Deco",
                Image = "isis.png"
            });
            CarouselItems.Add(new CarouselItem()
            {
                Title = "Ancient China",
                Description = "The arts of the clothing creation and styling in the East, only this December",
                Image = "ancientchina.png"
            });
        }
    }
}
