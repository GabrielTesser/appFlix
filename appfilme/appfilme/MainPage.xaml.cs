using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using appfilme.categoria;


namespace appfilme
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("appfilme.poster.logos.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Btn_Open_Aventura (object sender, EventArgs e)
        {
            
            try
            {
               await Navigation.PushAsync(new categoria.aventura());

            }catch (Exception ex)
            {

              await  DisplayAlert("Ops", ex.Message, "OK");

            }
        }

        private async void Btn_Open_Comedia (object sender, EventArgs e)
        {
            try
            {
                 await Navigation.PushAsync(new categoria.comedia());

            }catch(Exception ex)
            {

                await DisplayAlert("Ops", ex.Message, "OK");

            }

        }

        private async void Btn_Open_Drama(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new categoria.drama());

            }
            catch (Exception ex)
            {

                await DisplayAlert("Ops", ex.Message, "OK");

            }
        }

        private async void Btn_Open_Terror (object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new categoria.terror());

            }
            catch (Exception ex)
            {

                await DisplayAlert("Ops", ex.Message, "OK");

            }
        }
    }
}
