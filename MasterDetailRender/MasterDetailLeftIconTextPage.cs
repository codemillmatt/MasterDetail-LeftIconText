using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MasterDetailRender
{
    public class MasterDetailLeftIconTextPage : MasterDetailPage
    {
        public MasterDetailLeftIconTextPage()
        {
        }

        #region Left Title

        public static readonly BindableProperty LeftTitleProperty = BindableProperty.CreateAttached("LeftTitle", typeof(string), typeof(MasterDetailLeftIconTextPage),
                                                                                                    string.Empty, BindingMode.Default, null, LeftTitleChanged);

        public static string GetLeftTitle(BindableObject bindable)
        {
            return (string)bindable.GetValue(LeftTitleProperty);
        }

        public static void SetLeftTitle(BindableObject bindable, string value)
        {
            bindable.SetValue(LeftTitleProperty, value);
        }

        protected static void LeftTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(((Page)bindable)?.Parent is MasterDetailLeftIconTextPage parent)) return;

            parent.InternalLeftTitle = newValue.ToString();
        }

        // Could use messaging center instead of the "internal" properties
        public static readonly BindableProperty InternalLeftTitleProperty = BindableProperty.Create("InternalLeftTitle", typeof(string), typeof(MasterDetailLeftIconTextPage), 
                                                                                                    string.Empty, BindingMode.Default);

        string InternalLeftTitle
        {
            get => (string)GetValue(InternalLeftTitleProperty);
            set => SetValue(InternalLeftTitleProperty, value);
        }

        #endregion

        #region Left Icon

        public static readonly BindableProperty LeftIconProperty = BindableProperty.CreateAttached("LeftIcon", typeof(string), typeof(MasterDetailLeftIconTextPage),
                                                                                                   string.Empty, BindingMode.Default, null, LeftIconChanged);

        public static string GetLeftIcon(BindableObject bindable)
        {
            return (string)bindable.GetValue(LeftIconProperty);
        }

        public static void SetLeftIcon(BindableObject bindable, string value)
        {
            bindable.SetValue(LeftIconProperty, value);
        }

        protected static void LeftIconChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(((Page)bindable)?.Parent is MasterDetailLeftIconTextPage parent)) return;

            parent.InternalLeftIcon = newValue.ToString();
        }

        public static readonly BindableProperty InternalLeftIconProperty = BindableProperty.Create("InternalLeftIcon", typeof(string), typeof(MasterDetailLeftIconTextPage), 
                                                                                                   string.Empty, BindingMode.Default);

        public string InternalLeftIcon
        {
            get => (string)GetValue(InternalLeftIconProperty);
            set => SetValue(InternalLeftIconProperty, value);
        }

        #endregion
    }
}
