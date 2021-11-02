using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public string T;
        public HomePage(string Text)
        {
            InitializeComponent();
            T= Text;
            la.Text = T;
        }

        private  async void Bu1_Clicked(object sender, EventArgs e)
        {
            if(la.Text != "start")
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }
            await Application.Current.MainPage.Navigation.PushModalAsync(new PlayPage("1"));
        }

        private async void Bu2_Clicked(object sender, EventArgs e)
        {
            if (la.Text != "start")
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }
            await Application.Current.MainPage.Navigation.PushModalAsync(new PlayPage("2"));
        }
    }
}