using System;
using System.Collections.Generic;
using System.Text;
using VodacomKZNui.Core.ViewModels;

namespace VodacomKZNui.Core.Data
{
    public interface IDataService<T> where T : class
    {
        IObservable<IEnumerable<T>> GetFullList();
        IEnumerable<T> QueryList(IEnumerable<T> list, string query);
        IEnumerable<ItemPickerListGrouping<string, T>> GroupListAsync(List<T> itmes);
    }
}
