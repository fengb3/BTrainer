using Xamarin.Forms;
using BTrainer.Service;

namespace BTrainer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DB.OpenConnection();
            MainPage = new View.MainPage();
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
