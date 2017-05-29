using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailRender
{
    public partial class MasterContentPage : ContentPage
    {
        public MasterContentPage()
        {
            InitializeComponent();

            this.BindingContext = new MasterContentViewModel();
        }
    }
}
