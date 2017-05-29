using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailRender
{
    public partial class GrillPage : ContentPage
    {
        public GrillPage()
        {
            InitializeComponent();

            navigateButton.Clicked += async (sender, e) => await Navigation.PushAsync(new ChildPage());
        }
    }
}
