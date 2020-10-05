using System;
using System.Collections.Generic;
using System.Text;
using SfcoPadel.Domain.Courts;
using Xamarin.Forms.GoogleMaps;

namespace SfcoPadel.UI.Map.Models
{
    public class CourtLocation
    {
        public Court Court { get; set; }

        public Position Position { get; set; }

        public BitmapDescriptor Icon { get; set; }
         
        //public Pin Pin { get; set; }
    }
}
