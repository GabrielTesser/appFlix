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
    public partial class comedia : ContentPage
    {
        public comedia()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("appfilme.poster.logos.png");
            as_branquelas.Source = ImageSource.FromResource("appfilme.poster.comedia.as_branquelas.jpg");
            click.Source = ImageSource.FromResource("appfilme.poster.comedia.click.jpg");
            deadpool.Source = ImageSource.FromResource("appfilme.poster.comedia.deadpool.jpg");
            super_heroi.Source = ImageSource.FromResource("appfilme.poster.comedia.super_heroi.jpg");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void as_branquelas_Clicked(object sender, EventArgs e)
        {

        }

        private void click_Clicked(object sender, EventArgs e)
        {

        }

        private void deadpool_Clicked(object sender, EventArgs e)
        {

        }

        private void super_heroi_Clicked(object sender, EventArgs e)
        {

        }
    }
}