using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VodacomKZNui.Core.ViewModels;
using VodacomKZNui.Module.Accident.Model;

namespace VodacomKZNui.Module.Accident.Service
{
    public class ArrestUpdate : IArrestUpdate
    {
        public async Task<IEnumerable<Arrest>> GetCurrentArrestListAsync()
        {
            return await GetArrestAsync();
        }


        private async Task<IEnumerable<Arrest>> GetArrestAsync()
        {

              List<Arrest> arrests = new List<Arrest>
              {
                        new Arrest{ArrestId = 1, CaseNumber ="847-745",IdNumber = "9206116387082", Initial="S P", LastName ="Mdluli",InvistigatorOfficer= "Sabelo" ,NameOfPoliceStation ="Pretoria" },
                        new Arrest{ArrestId = 2, CaseNumber ="747-745",IdNumber = "9206116387082", Initial="F F", LastName ="Mamba",InvistigatorOfficer= "Gift" ,NameOfPoliceStation ="Kwamashu" },
                         new Arrest{ArrestId = 3, CaseNumber ="447-745",IdNumber = "9206116387082", Initial="J P", LastName ="Mamabolo",InvistigatorOfficer= "Lethabo" ,NameOfPoliceStation ="Polokwane" }
              };

            return arrests;

        }

    }
    
}
