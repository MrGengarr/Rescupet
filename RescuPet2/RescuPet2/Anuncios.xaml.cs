using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RescuPet2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anuncios : ContentPage
    {
        public Anuncios()
        {
            InitializeComponent();
            BindingContext = new HomepageViewModel();
        }
    }
}