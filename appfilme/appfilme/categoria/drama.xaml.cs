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
    public partial class drama : ContentPage
    {
        public drama()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("appfilme.poster.logos.png");

            jogo_imitacao.Source = ImageSource.FromResource("appfilme.poster.drama.jogo_imitacao.jpg");
            me_chame.Source = ImageSource.FromResource("appfilme.poster.drama.me_chame.jpg");
            rede_social.Source = ImageSource.FromResource("appfilme.poster.drama.rede_social.jpg");
            sonho_possivel.Source = ImageSource.FromResource("appfilme.poster.drama.sonho_possivel.jpg");


            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void jogo_imitacao_Clicked(object sender, EventArgs e)
        {

        }

        private void me_chame_Clicked(object sender, EventArgs e)
        {

        }

        private void rede_social_Clicked(object sender, EventArgs e)
        {

        }

        private void sonho_possivel_Clicked(object sender, EventArgs e)
        {

        }
    }
}