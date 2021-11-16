using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Your_Style_v1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.V_RegistrarCita());
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
