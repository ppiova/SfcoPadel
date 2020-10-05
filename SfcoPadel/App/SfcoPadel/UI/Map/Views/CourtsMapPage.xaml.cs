using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SfcoPadel.UI.Map.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace SfcoPadel.UI.Map.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourtsMapPage : ContentPage
    {
        public CourtsMapPage()
        {
            InitializeComponent();
           
        }

       void InfoWindowClicked(System.Object sender, Xamarin.Forms.GoogleMaps.InfoWindowClickedEventArgs e)
        {
            ((CourtsMapPageViewModel)this.BindingContext).InfoWindowSelected(e.Pin);
        }
    }
}