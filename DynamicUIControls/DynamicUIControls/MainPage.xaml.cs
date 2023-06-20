using DynamicUIControls.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicUIControls
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            //viewModel = new MainPageViewModel();
            //this.BindingContext = viewModel;
            //viewModel.LoadData();

        }
    }
}
