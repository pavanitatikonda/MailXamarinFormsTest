using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void OnMailSend(object sender, EventArgs e)
        {
            DependencyService.Get<IMailService>().sendMail();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {

        }
     }
 }
