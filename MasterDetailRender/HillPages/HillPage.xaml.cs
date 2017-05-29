using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailRender
{
    public partial class HillPage : ContentPage
    {
        public HillPage()
        {
            InitializeComponent();

            navigateButton.Clicked += async (sender, e) => await Navigation.PushAsync(new ChildPage());
        }
    }
}
