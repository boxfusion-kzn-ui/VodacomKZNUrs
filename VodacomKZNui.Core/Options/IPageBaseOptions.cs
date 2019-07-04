using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VodacomKZNui.Core.Options
{
    public interface IPageBaseOptions
    {
        string Title { get; set; }
        string BackgroundImage { get; set; }
        Color BackgroundColor { get; set; }
    }
}
