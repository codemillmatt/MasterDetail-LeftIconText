using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailRender
{
    public partial class FirePage : ContentPage
    {
        public FirePage()
        {
            InitializeComponent();

            navigateButton.Clicked += async (sender, e) => await Navigation.PushAsync(new ChildPage());
        }
    }
}
