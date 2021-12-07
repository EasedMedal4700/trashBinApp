using System;
using System.Collections.Generic;
using System.ComponentModel;
using trashBinAppItSelf.Models;
using trashBinAppItSelf.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trashBinAppItSelf.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}