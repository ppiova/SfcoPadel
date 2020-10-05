using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Prism.Navigation;
using SfcoPadel.UI.Map.Models;
using SfcoPadel.UI.ViewModels;
using SfcoPadel.UseCases.Courts;
using Xamarin.Forms.GoogleMaps;

namespace SfcoPadel.UI.Map.ViewModels
{
    public class CourtsMapPageViewModel : ViewModelBase
    {
        public ObservableCollection<CourtLocation> Locations { get; set; }
        private readonly GetAllCourts _getAllCourts;
        private readonly string markerIcon = "marker.png";

        public CourtsMapPageViewModel(INavigationService navigationService, GetAllCourts getAllCourts)
            : base(navigationService)
        {
            _getAllCourts = getAllCourts;
            Title = "Canchas";
            Locations = new ObservableCollection<CourtLocation>();
            LoadCourtsLocations();


        }

        private async void LoadCourtsLocations()
        {
            foreach (var item in await _getAllCourts.Invoke())
            {
                Locations.Add(new CourtLocation
                {
                    Position = new Position(item.Latitude, item.Longitude),
                    Court = item,
                    Icon = BitmapDescriptorFactory.FromBundle(markerIcon)
                });
            }
        }
        public void InfoWindowSelected(Pin pin)
        {
            var courtDetails = Locations.FirstOrDefault(l => l.Court.Name == pin.Label & l.Position.Equals(pin.Position));
            var navParams = new NavigationParameters();
            navParams.Add("CourtDetails", courtDetails.Court);
                NavigationService.NavigateAsync("CourtDetailsPage", navParams);
        }
    }
    
    
}
