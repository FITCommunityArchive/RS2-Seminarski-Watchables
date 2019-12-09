using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Watchables.Mobile.Models;
using Watchables.Mobile.Views;
using Watchables.Mobile.ViewModels;

namespace Watchables.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel = null;

        public ItemsPage() {
            InitializeComponent();
            BindingContext = _viewModel = new ItemsViewModel();
        }






    }
}