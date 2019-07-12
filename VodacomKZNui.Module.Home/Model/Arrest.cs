using System;
using System.Collections.Generic;
using System.Text;

namespace VodacomKZNui.Module.Home.Model
{
   public class Arrest
    {

        public Arrest()
        {

            LastName = string.Empty;
            Initial = string.Empty;
            NameOfPoliceStation = string.Empty;
            InvistigatorOfficer = string.Empty;

        }
        public int ArrestId { get; set; }
        public string LastName { get; set; }
        public string Initial { get; set; }
        public string IdNumber { get; set; }
        public string NameOfPoliceStation { get; set; }
        public string CaseNumber { get; set; }
        public string InvistigatorOfficer { get; set; }
        public bool BloodTaken { get; set; }
        public string Url { get; set; }
    }
}
