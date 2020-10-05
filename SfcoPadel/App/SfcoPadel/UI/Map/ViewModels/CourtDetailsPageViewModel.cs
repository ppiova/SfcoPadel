using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using SfcoPadel.Domain.Courts;
using SfcoPadel.UI.ViewModels;
using Xamarin.Essentials;

namespace SfcoPadel.UI.Map.ViewModels
{
    public class CourtDetailsPageViewModel : ViewModelBase
    {
        public Court Court { get; set; }
        public ObservableCollection<CourtImage> Images { get; set; }
        public ObservableCollection<CourtPhone> Phones { get; set; }

        public DelegateCommand NavigateToLocationCommand { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { SetProperty(ref address, value); }
        }
        private string blindex;
        public string Blindex
        {
            get { return blindex; }
            set { SetProperty(ref blindex, value); }
        }
        private string inDoor;
        public string InDoor
        {
            get { return inDoor; }
            set { SetProperty(ref inDoor, value); }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set { SetProperty(ref price, value); }
        }

        private string distance;
        public string Distance
        {
            get { return distance; }
            set { SetProperty(ref distance, value); }
        }
        public CourtDetailsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Images = new ObservableCollection<CourtImage>();
            Phones = new ObservableCollection<CourtPhone>();
            NavigateToLocationCommand = new DelegateCommand(async () => await NavigateToLocation());

        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Court = parameters.GetValue<Court>("CourtDetails");
            Name = Court.Name;
            Address = Court.Address;
            Blindex = Court.Blindex ? "SI" : "NO";
            InDoor = Court.Indoor ? "SI" : "NO";
            Price = Court.Price; 


            //TODO: Get the current user's position and calculate distance
            //Court.Latitude / Longitude => with apiGoogle calculate distance My Position and PIN
            Distance = "0.2 KMs";
            
            
            foreach (var item in Court.Images)
            {
                Images.Add(item);
            }
            foreach (var item in Court.Phones)
            {
                Phones.Add(item);
            }
          
        }

        public async Task NavigateToLocation()
        {
            var location = new Location(Court.Latitude, Court.Longitude);
            var options = new MapLaunchOptions { NavigationMode = Xamarin.Essentials.NavigationMode.Driving };

            try
            {
                await Xamarin.Essentials.Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                // No map application available to open or placemark can not be located
            }
        }

    }
}
