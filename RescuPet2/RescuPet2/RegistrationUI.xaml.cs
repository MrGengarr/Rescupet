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
    public partial class RegistrationUI : ContentPage
    {
        public RegistrationUI()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Confirmación", "Tu cuenta ha sido creada!", "OK");
            Navigation.PushAsync(new LoginUI());
        }
    }
}