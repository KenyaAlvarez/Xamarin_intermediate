using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CursoMvvm.views;

namespace CursoMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new views.Page();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
