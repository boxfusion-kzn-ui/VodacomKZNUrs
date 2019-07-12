using System;
using System.Collections.Generic;
using System.Text;

namespace VodacomKZNui.Core.Services
{
    interface IDataService<T> where T : class
    {
        IObservable<IEnumerable<T>> GetFullList();
        IEnumerable<T> QueryList(IEnumerable<T> list, string query);
    }
}
