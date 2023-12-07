using System;
using System.Collections.Generic;
using System.ComponentModel;
using Testeo_Login.Models;
using Testeo_Login.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testeo_Login.Views
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