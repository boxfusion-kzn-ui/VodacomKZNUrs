using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VodacomKZNui
{
    public static class Palette
    {
        /// <summary>
        /// PALETTE:
        /// Colour palette generated with the help of http://www.materialpalette.com/
        /// </summary>
        /// DividerColor

        public static readonly Color PrimaryLightColor = Color.FromHex(AppConfig.PrimaryLightColor);
        public static readonly Color PrimaryColor = Color.FromHex(AppConfig.PrimaryColor);
        public static readonly Color PrimaryDarkColor = Color.FromHex(AppConfig.PrimaryDarkColor);
        public static readonly Color AccentColor = Color.FromHex(AppConfig.AccentColor);
        public static readonly Color TextIconColor = Color.FromHex(AppConfig.TextIconColor);
        public static readonly Color PrimaryTextColor = Color.FromHex(AppConfig.PrimaryTextColor);
        public static readonly Color SecondaryTextColor = Color.FromHex(AppConfig.SecondaryTextColor);
        public static readonly Color DividerColor = Color.FromHex(AppConfig.DividerColor);
        public static readonly Color BadgeBackgroundColor = Color.FromHex(AppConfig.BadgeBackgroundColor);

        // General colors
        public static readonly Color CardPageBackgroundColor = Color.FromHex("#F5F5F5");
        public static readonly Color PageDefaultBackgroundColor = Color.FromHex("#ECF0F1");
        public static readonly Color NavigationBarColor = Color.FromHex("#ECF0F1");
        public static readonly Color NavigationBarTextColor = Color.FromHex("#000000");

        public static readonly Color ToggleOffButtonColor = SecondaryTextColor;  // Color to be used for Toggle or Group buttons when not selected/switched
        public static readonly Color ButtonTextColor = TextIconColor;

        // Home Page Specific
        public static readonly Color HomePageBackgroundColor = PrimaryDarkColor; //PRIMARY_COLOR;
        public static readonly Color HomePageTitleColor = PrimaryLightColor;
        public static readonly Color HomePageIconColor = Color.FromHex("#005391");//PrimaryColor;// TEXT_ICON_COLOR;
                                                                                  //public static readonly Color HomePageIconColor = TEXT_ICON_COLOR;// TEXT_ICON_COLOR;
        public static readonly Color HomePageIconLabelColor = PrimaryLightColor;
        //public static readonly Color HomePageIconLabelColor = PrimaryLightColor; //AccentColor; // PRIMARY_900;
        public static readonly Color PageBackgroundColor = Color.FromHex("#F5F5F5");
        // Form Entry Pages
        public static readonly Color EditPageFieldContainerBackgroundColor = Color.White;
        public static readonly Color EditPageFieldLabelTextColor = PrimaryTextColor;
        public static readonly Color EditPageFieldValueTextColor = PrimaryTextColor;
        public static readonly Color EditPageFieldPlaceholderTextColor = Color.Gray;
        public static readonly Color EditPageFieldHintTextColor = SecondaryTextColor;
        public static readonly Color EditPageFieldValidationErrorTextColor = Color.Red;

        // Details Pages
        public static readonly Color DetailsPageSectionHeadingBackgroundColor = Color.FromHex("#005391");//PrimaryColor;
        public static readonly Color DetailsPageSectionHeadingTextColor = TextIconColor;
        public static readonly Color DetailsPageFieldLabelTextColor = SecondaryTextColor;
        public static readonly Color DetailsPageFieldValueTextColor = PrimaryTextColor;

        // ListItem Pages
        public static readonly Color ListPageUnopenedItemBackgroundColor = PrimaryLightColor;
        public static readonly Color ListPageGroupingBackgroundColor = Color.FromHex("#005391"); // = PrimaryColor;
        public static readonly Color ListPageGroupingTextColor = TextIconColor;
        public static readonly Color ListPageItemTitleTextColor = PrimaryTextColor;
        public static readonly Color ListPageItemDetailTextColor = SecondaryTextColor;
        public static readonly Color ListPageItemSmallDetailTextColor = SecondaryTextColor;
        public static readonly Color ListPageSeparatorColor = DividerColor;
        public static readonly Color UserProfilePic_Background_Color = Color.FromHex("#d3d3d3");
        public static readonly Color NotificationBoxColor = Color.FromHex("#b4b4b4");
        public static readonly Color GoldColor = Color.FromHex("#bf9d2f");
        public static readonly Color EmptyListPlaceholderColor = Color.FromHex("#b4b4b4");



    }

    public class AppConfig
    {
        public const string PrimaryColor = "#c36a21";
        public const string PrimaryLightColor = "#FFE0B2";
        public const string PrimaryDarkColor = "#FF9800";
        public const string AccentColor = "#62a73b";
        public const string TextIconColor = "#FFFFFF";
        public const string PrimaryTextColor = "#000000";
        public const string SecondaryTextColor = "#757575";
        public const string DividerColor = "#B6B6B6";
        public const string WindowBackground = "#BDBDBD";
        public const string BadgeBackgroundColor = "#FF0000";
        public static string FacilityMapPinColor = "#FF0000";
        public const bool CanComment = true;
        public const string SenderId = "828733662875";
        public const bool CanDirectMessage = false;
        public const string Environment = "saps";
        public const string AppName = "Shesha Mobile";
    }
}
