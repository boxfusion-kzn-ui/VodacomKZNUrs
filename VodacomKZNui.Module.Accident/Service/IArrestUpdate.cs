using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VodacomKZNui.Core.Data;
using VodacomKZNui.Module.Accident.Model;

namespace VodacomKZNui.Module.Accident.Service
{
    public interface IArrestUpdate
    {
        Task<IEnumerable<Arrest>> GetCurrentArrestListAsync();
       
    }
}
