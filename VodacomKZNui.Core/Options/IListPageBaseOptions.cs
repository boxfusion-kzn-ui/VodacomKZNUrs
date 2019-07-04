using System;
using System.Collections.Generic;
using System.Text;
using VodacomKZNui.Core.ViewModels;

namespace VodacomKZNui.Core.Options
{
    public interface IListPageBaseOptions : IPageBaseOptions
    {
        string DrillDownPage { get; set; }
        long? TagsFilter { get; set; }
        long? CacheValidity { get; set; }
        ListItemPickerMode PickerMode { get; set; }
        string PlaceHolderText { get; set; }
        bool AllowPullToRefresh { get; set; }
    }
}
