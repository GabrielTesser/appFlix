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
    public partial class terror : ContentPage
    {
        public terror()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("appfilme.poster.logos.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}