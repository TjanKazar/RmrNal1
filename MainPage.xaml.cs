namespace RmrNal1
{
	public partial class MainPage : ContentPage
	{
		string cUser = "username";
		string cPass = "geslo";
		public MainPage()
		{
			InitializeComponent();
		}


		private async void handleLogin(object sender, EventArgs e)
		{
			if (cUser == usernameField.Text && cPass == passwordField.Text)
			{
				await Navigation.PushAsync(new NewPage1());
			}
		}
		private async void VizitkaOnClick(object sender, EventArgs e)
		{

			await Navigation.PushAsync(new NewPage2());

		}

	}
}
