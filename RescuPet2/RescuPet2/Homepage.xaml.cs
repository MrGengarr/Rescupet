using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RescuPet2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Homepage : ContentPage
    {
        ObservableCollection<FileImageSource> imgSources = new ObservableCollection<FileImageSource>();
        public Homepage()
        {
            InitializeComponent();
            imgSources.Add("img1.png");
            imgSources.Add("img2.png");
            imgSources.Add("img3.png");
            imgSlider.Images = imgSources;

            BindingContext = new HomepageViewModel();
        }

        public void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string test = e.CurrentSelection.ToString();
        }
    }
}