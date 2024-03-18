using AccuTrackDefault.Views.Auth;

namespace AccuTrackDefault
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }
    }
}
