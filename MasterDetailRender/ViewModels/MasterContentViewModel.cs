using System;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq.Expressions;
namespace MasterDetailRender
{
    public class MasterContentViewModel : INotifyPropertyChanged
    {
        public MasterContentViewModel()
        {
            MasterTitle = "Fire";
            MasterIcon = "fire.png";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        string masterTitle;
        public string MasterTitle
        {
            get => masterTitle;
            set
            {
                masterTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MasterTitle)));
            }
        }

        string masterIcon;
        public string MasterIcon
        {
            get => masterIcon;
            set
            {
                masterIcon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MasterIcon)));
            }
        }

        ICommand navToFire;
        public ICommand NavToFireCommand =>
        navToFire ?? (navToFire = new Command(() =>
        {            
            if (!(App.Current.MainPage is MasterDetailPage mp)) return;

            MasterTitle = "Fire";
            MasterIcon = "fire.png";

            mp.Detail = new NavigationPage(new FirePage());

        }));

        ICommand navToHills;
        public ICommand NavToHillsCommand =>
        navToHills ?? (navToHills = new Command(() =>
        {              
            if (!(App.Current.MainPage is MasterDetailPage mp)) return;

            MasterTitle = "Hills";
            MasterIcon = "mountain.png";

            mp.Detail = new NavigationPage(new HillPage());

        }));

        ICommand navToGrill;
        public ICommand NavToGrillCommand =>
        navToGrill ?? (navToGrill = new Command(() =>
        {
            if (!(App.Current.MainPage is MasterDetailPage mp)) return;

            MasterTitle = "Grill";
            MasterIcon = "grill.png";

            mp.Detail = new NavigationPage(new GrillPage());
        }));
    }
}
