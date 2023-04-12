using System;
using Xamarin.Forms;
using XamarinStyles.Views;

namespace XamarinStyles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void NavigateToImplicitStylesPage(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new ImplicitStylesPage());
        }

        private async void NavigateToExplicitStylesPage(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new ExplicitStylesPage());
        }

        private async void NavigateToGlobalStylesPage(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new GlobalStylesPage());
        }
    }
}
