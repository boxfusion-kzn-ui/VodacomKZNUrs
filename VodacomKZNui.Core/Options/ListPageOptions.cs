using System;
using System.Collections.Generic;
using System.Text;
using VodacomKZNui.Core.ViewModels;

namespace VodacomKZNui.Core.Options
{
    public class ListPageOptions : PageOptions, IListPageBaseOptions
    {
        public ListPageOptions()
        {
            CacheValidity = 120;
            PickerMode = ListItemPickerMode.LoadTheFullList;
        }
        public long? CacheValidity { get; set; }

        public long? TagsFilter { get; set; }

        public string DrillDownPage { get; set; }
        public ListItemPickerMode PickerMode { get; set; }
        public string PlaceHolderText { get; set; }
        public bool AllowPullToRefresh { get; set; }
    }
}
