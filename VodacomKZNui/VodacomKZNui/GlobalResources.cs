using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VodacomKZNui
{
    public class GlobalResources
    {
        public static void Initialise()
        {
            Application.Current.Resources = new ResourceDictionary();

            InitDetailsSectionHeaderStyles();
            InitFormPageStyles();
            InitListPageStyles();
        }

        private static void InitDetailsSectionHeaderStyles()
        {
            #region DetailsPageStyles

            // Section separator
            Application.Current.Resources.Add("detailSectionHeadingLayout", new Style(typeof(StackLayout))
            {
                Setters =
                {
                    new Setter {Property = Layout.PaddingProperty, Value = new Thickness(10, 0, 10, 5)},
                    //new Setter { Property = StackLayout.BackgroundColorProperty,   Value = Palette.DetailsPageSectionHeadingBackgroundColor },
                    new Setter {Property = VisualElement.HeightRequestProperty, Value = 33}
                }
            });

            Application.Current.Resources.Add("detailSectionHeadingLabel", new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter {Property = Label.VerticalTextAlignmentProperty, Value = TextAlignment.End},
                    new Setter {Property = Label.FontSizeProperty, Value = NamedSize.Small},
                    //new Setter { Property = Label.TextColorProperty,   Value = Palette.DetailsPageSectionHeadingTextColor },
                    new Setter {Property = Label.FontAttributesProperty, Value = FontAttributes.None},
                    new Setter {Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation},
                    new Setter {Property = View.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                    new Setter {Property = View.VerticalOptionsProperty, Value = LayoutOptions.EndAndExpand}
                }
            });

            // Section sub-title
            // FieldFrame
            // FieldLabel
            // FieldValue

            //var buttonStyle = 

            //Resources.Add("buttonStyle", buttonStyle);

            #endregion
        }

        private static void InitListPageStyles()
        {
            // Section separator
            Application.Current.Resources.Add("listEmptyListPlaceholderLayout", new Style(typeof(StackLayout))
            {
                Setters =
                {
                    new Setter {Property = View.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                    new Setter {Property = View.VerticalOptionsProperty, Value = LayoutOptions.Fill},
                    new Setter {Property = Layout.PaddingProperty, Value = new Thickness(20)},
                    new Setter {Property = VisualElement.MinimumHeightRequestProperty, Value = 100}
                }
            });

            Application.Current.Resources.Add("listEmptyListPlaceholderLabel", new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter {Property = Label.FontSizeProperty, Value = NamedSize.Medium},
                    // new Setter { Property = Label.TextColorProperty,   Value = Palette.SecondaryTextColor },
                    new Setter {Property = Label.FontAttributesProperty, Value = FontAttributes.None},
                    new Setter {Property = Label.LineBreakModeProperty, Value = LineBreakMode.WordWrap},
                    new Setter {Property = View.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                    new Setter {Property = View.VerticalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                    new Setter {Property = Label.HorizontalTextAlignmentProperty, Value = TextAlignment.Center},
                    new Setter {Property = Label.VerticalTextAlignmentProperty, Value = TextAlignment.End}
                }
            });
        }

        private static void InitFormPageStyles()
        {
            // Section separator
            Application.Current.Resources.Add("formFieldContainer", new Style(typeof(StackLayout))
            {
                Setters =
                {
                    new Setter {Property = StackLayout.OrientationProperty, Value = StackOrientation.Vertical},
                    new Setter {Property = View.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                    new Setter {Property = VisualElement.BackgroundColorProperty, Value = Color.White},
                    new Setter {Property = Layout.PaddingProperty, Value = new Thickness(0, 0, 0, 5)},
                    new Setter {Property = VisualElement.MinimumHeightRequestProperty, Value = 55}
                }
            });

            Application.Current.Resources.Add("AccentColor", Palette.AccentColor);
            Application.Current.Resources.Add("PrimaryColor", Palette.PrimaryColor);
            Application.Current.Resources.Add("PrimaryLightColor", Palette.PrimaryLightColor);
            Application.Current.Resources.Add("PrimaryDarkColor", Palette.PrimaryDarkColor);
            Application.Current.Resources.Add("PageBackgroundColor", Palette.PageBackgroundColor);
            Application.Current.Resources.Add("BadgeBackgroundColor", Palette.BadgeBackgroundColor);
            Application.Current.Resources.Add("SecondaryTextColor", Palette.SecondaryTextColor);
            Application.Current.Resources.Add("EmptyListPlaceholderColor", Palette.EmptyListPlaceholderColor);
            Application.Current.Resources.Add("PrimaryTextColor", Palette.PrimaryTextColor);
            Application.Current.Resources.Add("PageDefaultBackgroundColor", Palette.PageDefaultBackgroundColor);
            Application.Current.Resources.Add("GoldColor", Palette.GoldColor);
            Application.Current.Resources.Add("EditPageFieldPlaceholderTextColor", Palette.EditPageFieldPlaceholderTextColor);
            Application.Current.Resources.Add("EditPageFieldValueTextColor", Palette.EditPageFieldValueTextColor);
            Application.Current.Resources.Add("EditPageFieldValidationErrorTextColor", Palette.EditPageFieldValidationErrorTextColor);





            Application.Current.Resources.Add("ListItemRightArrow", UIStandard.ListItemRightArrow);
            Application.Current.Resources.Add("LeftFontIconSize", UIStandard.LeftFontIconSize);
            Application.Current.Resources.Add("LeftSmallFontIconSize", UIStandard.LeftSmallFontIconSize);

            Application.Current.Resources.Add("SidesPaddingUnderMenue", UIStandard.SidesPaddingUnderMenue);
            Application.Current.Resources.Add("PrimaryTextSize", UIStandard.PrimaryTextSize);
            Application.Current.Resources.Add("ListPageGroupingBackgroundColor", Palette.ListPageGroupingBackgroundColor);
            Application.Current.Resources.Add("ListPageGroupingTextColor", Palette.ListPageGroupingTextColor);
            Application.Current.Resources.Add("TopAndBottomSpaces", UIStandard.TopAndBottomSpaces);
            Application.Current.Resources.Add("NotificationBoxColor", Palette.NotificationBoxColor);
            Application.Current.Resources.Add("SidesPaddingOnHints", UIStandard.SidesPaddingOnHints);
            Application.Current.Resources.Add("SidesPadding", UIStandard.SidesPadding);
            Application.Current.Resources.Add("AudioIconLargeFont", UIStandard.AudioIconLargeFont);
            Application.Current.Resources.Add("LabelWidthForRightEntry", UIStandard.LabelWidthForRightEntry);
            Application.Current.Resources.Add("EmptyListIconSize", UIStandard.EmptyListIconSize);

        }
    }
}
