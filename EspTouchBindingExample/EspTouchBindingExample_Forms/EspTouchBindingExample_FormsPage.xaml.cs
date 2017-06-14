using Xamarin.Forms;

namespace EspTouchBindingExample_Forms
{
    public partial class EspTouchBindingExample_FormsPage : ContentPage
    {
        ViewModel model;
        public EspTouchBindingExample_FormsPage()
        {
            model = new ViewModel();
            BindingContext = model;
            InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			if (model.Ssid != string.Empty && model.Passphrase != string.Empty)
			{
				await model.ConfigDevice();
			}
			else
			{
				model.Message = "Enter the passphrase or verify you are connected to a network";
			}
		}
    }
}
