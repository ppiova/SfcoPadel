using System;
using System.Collections.Generic;
using System.Text;

namespace SfcoPadel.Domain.Courts
{
    public class Court
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Blindex { get; set; }
        public bool Indoor { get; set; }
        public string Price { get; set; }

        public List<CourtImage> Images { get; set; }
        public List<CourtPhone> Phones { get; set; }
    }
}
