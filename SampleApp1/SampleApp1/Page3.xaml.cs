using Android.Widget;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        Page3ViewModel _viewModel;
        public Page3()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            _viewModel = new Page3ViewModel();
            BindingContext = _viewModel;
        }
        protected override void OnAppearing()
        {
            _viewModel.gettime();
            base.OnAppearing();
        }

        private void OnIconTapped(object sender, EventArgs e)
        {
            var image = sender as Image;
            //var res = image.BindingContext as DashboardItemUnit;
            var img = image.BindingContext;

            //if(img as HelpPage == HelpPage)
            //{

            //}
        }
    }
}