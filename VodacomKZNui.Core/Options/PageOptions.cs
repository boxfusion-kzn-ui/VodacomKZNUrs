using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VodacomKZNui.Core.Options
{
  public  class PageOptions : IPageBaseOptions
    {
        public PageOptions() { }

        public PageOptions(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
        public string BackgroundImage { get; set; }
        public Color BackgroundColor { get; set; } = Color.White;
    }
}
