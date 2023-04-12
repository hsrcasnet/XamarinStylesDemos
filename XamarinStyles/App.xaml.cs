using Xamarin.Forms;

namespace XamarinStyles
{
    public partial class App : Application
    {
        public App()
        {
            // Demo: Override app theme manually
            this.UserAppTheme = OSAppTheme.Light;

            this.InitializeComponent();

            this.MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
