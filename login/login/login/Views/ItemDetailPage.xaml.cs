using login.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace login.Views
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