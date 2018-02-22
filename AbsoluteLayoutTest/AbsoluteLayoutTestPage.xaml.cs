using Xamarin.Forms;

namespace AbsoluteLayoutTest
{
    public partial class AbsoluteLayoutTestPage : ContentPage
    {
        public AbsoluteLayoutTestPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutProblem());
        }
    }
}
