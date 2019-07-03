using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VodacomKZNui
{
    public static class UIStandard
    {
        private static readonly int LeftRightPaddingValue = 18;
        private static readonly int LeftRightPaddingUnderMenuValue = 14;
        private static readonly int TopAndBottomPadding = 5;
        private static readonly int TopAndBottomPaddingOnHints = 15;

        #region Paddings
        public static readonly Thickness SidesPaddingUnderMenue = new Thickness(LeftRightPaddingValue, TopAndBottomPadding, LeftRightPaddingValue, TopAndBottomPadding);
        public static readonly Thickness SidesPaddingOnHints = new Thickness(LeftRightPaddingValue, TopAndBottomPaddingOnHints, LeftRightPaddingValue, TopAndBottomPaddingOnHints);           //Will be used on notes 
        public static readonly Thickness SidesPadding = new Thickness(LeftRightPaddingUnderMenuValue, TopAndBottomPadding, LeftRightPaddingUnderMenuValue, TopAndBottomPadding);
        public static readonly Thickness TopAndBottomSpaces = new Thickness(0, TopAndBottomPadding, 0, TopAndBottomPadding);
        public static readonly Thickness EmptyIconPadding = new Thickness(LeftRightPaddingValue);
        public static readonly double LabelWidthForRightEntry = 120;
        #endregion

        #region FontSizes
        public static readonly int LabelFontSize = 18;
        public static readonly double PrimaryTextSize = 14;
        public static readonly int SecondaryTextSize = 18;
        public static readonly double LeftFontIconSize = 50;
        public static readonly double LeftSmallFontIconSize = 20;
        public static readonly int ListHeaderHight = 40;
        public static readonly double HeadingTextSize = 18;
        public static readonly double ListItemRightArrow = 20;
        public static readonly double SubHeadingTextSize = 18;
        public static readonly string AudioIconLargeFont = "100";
        #endregion

        #region List View
        public static readonly int ListItemTitleTextSize = 18;
        public static readonly int ListItemSecondaryTextSize = 18;
        public static readonly int ListItemTertiaryTextSize = 18;
        public static readonly string EmptyListIconSize = "60";
        public static readonly string ListViewHeaderHeight = "42";
        public static readonly string ListViewHeaderTextSize = "16";
        public static readonly string ListViewLineBreakerHeight = "0.3";
        #endregion


    }
}

