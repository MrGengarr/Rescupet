﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RescuPet2
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            flyoutapp.listview.ItemSelected += OnSelectedItem;
        }

        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutItemPage;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                flyoutapp.listview.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
