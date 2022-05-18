using RescuPet2.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RescuPet2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreacionAnuncios : ContentPage
    {
        public CreacionAnuncios()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title="Por favor elige una imagen"
            });

            var stream = await result.OpenReadAsync();
            string name = result.FileName.ToString();

            if (name.Contains("dog6"))
            {
                await Navigation.PushAsync(new Pet9());
            }
        }
    }
}