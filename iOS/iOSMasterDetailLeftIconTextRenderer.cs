using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MasterDetailRender;
using MasterDetailRender.iOS;
using UIKit;
using CoreGraphics;
using CoreImage;

[assembly: ExportRenderer(typeof(MasterDetailLeftIconTextPage), typeof(iOSMasterDetailLeftIconTextRenderer))]
namespace MasterDetailRender.iOS
{    
    public class iOSMasterDetailLeftIconTextRenderer : PhoneMasterDetailRenderer
    {
        public iOSMasterDetailLeftIconTextRenderer()
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                Element.PropertyChanged -= Element_PropertyChanged;
            }

            if (e.NewElement != null)
            {
                Element.PropertyChanged += Element_PropertyChanged;    
            }
        }
              
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetupLeftButton();
		}

        void Element_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (!(Element is MasterDetailLeftIconTextPage mdp)) return;

            if (e.PropertyName == MasterDetailLeftIconTextPage.InternalLeftTitleProperty.PropertyName || e.PropertyName == MasterDetailLeftIconTextPage.InternalLeftIconProperty.PropertyName)
            {
                var title = (string)mdp.GetValue(MasterDetailLeftIconTextPage.InternalLeftTitleProperty);
                var icon = (string)mdp.GetValue(MasterDetailLeftIconTextPage.InternalLeftIconProperty);

                SetupLeftButton(title, icon);
                mdp.IsPresented = false;
            }
        }

        void SetupLeftButton(string buttonText = "", string buttonIcon = "")
        {
			if (!(Element is MasterDetailPage mdp)) return;
			if (!(Platform.GetRenderer(mdp.Detail) is UINavigationController nc)) return;

			UIButton btn = new UIButton(UIButtonType.Custom);
            btn.SetTitleColor(btn.TintColor, UIControlState.Normal);

			btn.Frame = new CGRect(0, 0, 100, 44);

            var title = string.IsNullOrEmpty(buttonText) ? mdp.Master.Title : buttonText;
            var icon = string.IsNullOrEmpty(buttonIcon) ? mdp.Master.Icon.File : buttonIcon;

            var img = UIImage.FromFile(icon);
			btn.SetTitle(title, UIControlState.Normal);
            btn.SetImage(img, UIControlState.Normal);
            btn.ImageEdgeInsets = new UIEdgeInsets(0, -15, 0, 0);
			btn.TouchUpInside += (sender, e) => mdp.IsPresented = true;

			var lbbi = new UIBarButtonItem(btn);



			nc.NavigationBar.TopItem.LeftBarButtonItem = lbbi;
        }
    }
}
