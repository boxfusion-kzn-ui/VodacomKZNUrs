using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VodacomKZNui.Core.ViewModels
{ /// <summary>
  ///     Generic class to allow ListView grouping
  ///     See more at: http://motzcod.es/post/94643411707/enhancing-xamarinforms-listview-with-grouping#sthash.0TKMnAw3.dpuf
  /// </summary>
  /// <typeparam name="K"></typeparam>
  /// <typeparam name="T"></typeparam>
    public class ItemPickerListGrouping<K, T> : ObservableCollection<T>
    {
        public ItemPickerListGrouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        public K Key { get; }
    }
}
