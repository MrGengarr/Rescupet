using RescuPet2.Adoption;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using RescuPet2;

namespace RescuAdoption2
{
    class AdoptionViewModel : BindableObject
    {
        private ObservableCollection<PetsForAdoption> test;
        public ObservableCollection<PetsForAdoption> Adoptions
        {
            get => test;
            set
            {
                if (value == test) return;
                test = value;
                OnPropertyChanged();
            }
        }

        public PetsForAdoption SelectedItem { get; set; }

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
                        await Navigation.PushAsync(new Adoption1());
                    }
                    else if (SelectedItem.Identifier == 2)
                    {
                        await Navigation.PushAsync(new Adoption2());
                    }
                    else if (SelectedItem.Identifier == 3)
                    {
                        await Navigation.PushAsync(new Adoption3());
                    }
                    else if (SelectedItem.Identifier == 4)
                    {
                        await Navigation.PushAsync(new Adoption4());
                    }
                    else if (SelectedItem.Identifier == 5)
                    {
                        await Navigation.PushAsync(new Adoption5());
                    }
                    else if (SelectedItem.Identifier == 6)
                    {
                        await Navigation.PushAsync(new Adoption6());
                    }
                    else if (SelectedItem.Identifier == 7)
                    {
                        await Navigation.PushAsync(new Adoption7());
                    }
                    else if (SelectedItem.Identifier == 8)
                    {
                        await Navigation.PushAsync(new Adoption8());
                    }
                    SelectedItem = null;
                });
            }
        }

        public AdoptionViewModel()
        {
            Adoptions = new ObservableCollection<PetsForAdoption>
            {
                new PetsForAdoption
                {
                    Name = "Luna",
                    Image = "dog7.jpg",
                    Colonia = "Playas de Tijuana",
                    Fecha = "22/3/22",
                    Identifier=1
                },
                new PetsForAdoption
                {
                    Name = "Milo",
                    Image = "cat7.jpg",
                    Colonia = "Playas de Tijuana",
                    Fecha = "22/3/22",
                    Identifier=2
                },
                new PetsForAdoption
                {
                    Name = "Leo",
                    Image = "dog8.jpg",
                    Colonia = "Playas de Tijuana",
                    Fecha = "22/3/22",
                    Identifier=3
                },
                new PetsForAdoption
                {
                    Name = "Oliver",
                    Image = "dog9.jpg",
                    Colonia = "Playas de Tijuana",
                    Fecha = "22/3/22",
                    Identifier=4
                },
                new PetsForAdoption
                {
                    Name = "Willow",
                    Image = "cat6.jpg",
                    Colonia = "Playas de Tijuana",
                    Fecha = "22/3/22",
                    Identifier=5
                },
                new PetsForAdoption
                {
                    Name = "Ollie",
                    Image = "cat5.jpg",
                    Colonia = "Playas de Tijuana",
                    Fecha = "22/3/22",
                    Identifier=6
                },
                new PetsForAdoption
                {
                    Name = "Trico",
                    Image = "cat4.jpg",
                    Colonia = "Playas de Tijuana",
                    Fecha = "22/3/22",
                    Identifier=7
                },
                new PetsForAdoption
                {
                    Name = "Micky",
                    Image = "dog5.jpg",
                    Colonia = "Playas de Tijuana",
                    Fecha = "22/3/22",
                    Identifier=8
                }
            };
        }
    }
}
