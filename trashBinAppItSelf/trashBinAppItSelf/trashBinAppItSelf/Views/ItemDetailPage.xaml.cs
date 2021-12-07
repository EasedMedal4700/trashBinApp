using System.ComponentModel;
using trashBinAppItSelf.ViewModels;
using Xamarin.Forms;

namespace trashBinAppItSelf.Views
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