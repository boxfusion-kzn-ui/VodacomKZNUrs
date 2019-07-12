using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms.Internals;

namespace VodacomKZNui.Module.Accident.Model
{
   
    public class Officer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Location { get; set; }
        public string GeoLocation { get; set; }
        public string Weather { get; set; }
        public string RoadCondition { get; set; }
        public int Speed { get; set; }
    }
}
