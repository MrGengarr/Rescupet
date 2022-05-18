using RescuPet2.Pets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RescuPet2
{
    class HomepageViewModel : BindableObject
    {
        private ObservableCollection<Mascotass> pets;
        public ObservableCollection<Mascotass>Pets
        {
            get => pets;
            set
            {
                if (value == pets) return;
                pets = value;
                OnPropertyChanged();
            }
        }

        public Mascotass SelectedItem { get; set; }

        INavigation Navigation => Application.Current.MainPage.Navigation;

        public ICommand ItemSelectedCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (SelectedItem == null)
                        return;

                    if (SelectedItem.Identifier == 1)
                    {
                        await Navigation.PushAsync(new Pet1());
                    }
                    else if (SelectedItem.Identifier == 2)
                    {
                        await Navigation.PushAsync(new Pet2());
                    }
                    else if (SelectedItem.Identifier == 3)
                    {
                        await Navigation.PushAsync(new Pet3());
                    }
                    else if (SelectedItem.Identifier == 4)
                    {
                        await Navigation.PushAsync(new Pet4());
                    }
                    else if (SelectedItem.Identifier == 5)
                    {
                        await Navigation.PushAsync(new Pet5());
                    }
                    else if (SelectedItem.Identifier == 6)
                    {
                        await Navigation.PushAsync(new Pet6());
                    }
                    else if (SelectedItem.Identifier == 7)
                    {
                        await Navigation.PushAsync(new Pet7());
                    }
                    else if (SelectedItem.Identifier == 8)
                    {
                        await Navigation.PushAsync(new Pet8());
                    }
                    SelectedItem = null;
                });
            }
        }

        public HomepageViewModel()
        {
            Pets = new ObservableCollection<Mascotass>
            {
                new Mascotass
                {
                    Name = "Lulu",
                    Image = "cat1.jpg",
                    Colonia = "Playas",
                    Fecha = "22/3/22",
                    Owner="Admin",
                    Identifier=1
                },
                new Mascotass
                {
                    Name = "Minnie",
                    Image = "cat2.jpg",
                    Colonia = "Playas",
                    Fecha = "15/1/22",
                    Owner="Admin",
                    Identifier=2
                },
                new Mascotass
                {
                    Name = "Luna",
                    Image = "dog2.jpg",
                    Colonia = "Playas",
                    Fecha = "8/1/22",
                    Owner="Admin",
                    Identifier=3
                },
                new Mascotass
                {
                    Name = "Kubo",
                    Image = "dog1.jpg",
                    Colonia = "Playas",
                    Fecha = "3/4/22",
                    Owner="Admin",
                    Identifier=4
                },
                new Mascotass
                {
                    Name = "Oslo",
                    Image = "dog3.jpg",
                    Colonia = "Playas",
                    Fecha = "12/2/22",
                    Owner="Admin",
                    Identifier=5
                },
                new Mascotass
                {
                    Name = "Max",
                    Image = "dog4.jpg",
                    Colonia = "Playas",
                    Fecha = "6/3/22",
                    Owner="Admin",
                    Identifier=6
                },
                new Mascotass
                {
                    Name = "Bella",
                    Image = "cat3.jpg",
                    Colonia = "Playas",
                    Fecha = "20/4/22",
                    Owner="Admin",
                    Identifier=7
                },
                new Mascotass
                {
                    Name = "Beethovan",
                    Image = "dog5.jpg",
                    Colonia = "Playas",
                    Fecha = "1/1/22",
                    Owner="Admin",
                    Identifier=8
                },
            };
        }
    }
}
