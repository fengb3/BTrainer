
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTrainer.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseDetailPage : ContentPage
    {
        public ExerciseDetailPage()
        {
            InitializeComponent();
           
        }

        private void Web_Navigated(object sender, WebNavigatedEventArgs e)
        {
            Web.Eval("var rect = document.getElementById(\"videoid\").getBoundingClientRect();window.scrollTo(0, rect.top)");
            Web.IsVisible = true;
            Loading.IsRunning = false;
        }
    }
}