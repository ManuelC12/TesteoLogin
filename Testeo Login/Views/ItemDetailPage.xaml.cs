using System.ComponentModel;
using Testeo_Login.ViewModels;
using Xamarin.Forms;

namespace Testeo_Login.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}