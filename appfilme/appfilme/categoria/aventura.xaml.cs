using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appfilme.categoria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class aventura : ContentPage
    {
        public aventura()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("appfilme.poster.logos.png");

            jungle_cruise.Source = ImageSource.FromResource("appfilme.poster.aventura.jungle_cruise.jpg");
            projeto_adam.Source = ImageSource.FromResource("appfilme.poster.aventura.projeto_adam.jpg");
            the_batman.Source = ImageSource.FromResource("appfilme.poster.aventura.the_batman.jpg");
            uncharted.Source = ImageSource.FromResource("appfilme.poster.aventura.uncharted.jpg");
            venom.Source = ImageSource.FromResource("appfilme.poster.aventura.venom.jpg");


            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void jungle_cruise_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new categoria.Page1());
            }catch (Exception ex)
            {
                await DisplayAlert("ops, ocorreu um erro...", ex.Message.ToString(), "ok");
            }
        }

        private void projeto_adam_Clicked(object sender, EventArgs e)
        {

        }

        private void the_batman_Clicked(object sender, EventArgs e)
        {

        }

        private void uncharted_Clicked(object sender, EventArgs e)
        {

        }

        private void venom_Clicked(object sender, EventArgs e)
        {

        }
    }
}