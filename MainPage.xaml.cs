using FirebaseAdmin.Auth;
using Firebase.Auth;
using System.Net.Http;

namespace RmrNal1
{
	public partial class MainPage : ContentPage
	{
		
		string apiKey = @"AIzaSyC63Kj9zh8wk3Ecafq9OuzkUaNVrlrtIuk";
		public string cUser;
		public string cPass;
		public MainPage()
		{
			InitializeComponent();
		}
		private async void handleLogin(object sender, EventArgs e)
		{
			
			cUser = usernameField.Text;
			cPass = passwordField.Text;
			await DisplayAlert("loggin attempt", "username: " + cUser + " password : " + cPass, "OK");
			try
			{
				var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
				var auth = await authProvider.SignInWithEmailAndPasswordAsync(cUser, cPass);
				string token = auth.FirebaseToken;
				await Navigation.PushAsync(new NewPage1());
			}
			catch (Exception ex)
			{
				await DisplayAlert("Login Error", ex.Message, "OK");
			}
		
		}
		private async void VizitkaOnClick(object sender, EventArgs e)
		{

			await Navigation.PushAsync(new NewPage2());

		}
		

	}
}
