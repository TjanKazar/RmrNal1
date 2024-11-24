using Firebase.Auth;
using Firebase.Database;
using Newtonsoft.Json;
using static Google.Apis.Requests.BatchRequest;

namespace RmrNal1
{
	public partial class MainPage : ContentPage
	{

		public string apiKey = @"AIzaSyC63Kj9zh8wk3Ecafq9OuzkUaNVrlrtIuk";
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
				HttpClient client = new HttpClient();
				HttpResponseMessage response = await client.GetAsync("https://rmrgoog-e6331-default-rtdb.europe-west1.firebasedatabase.app/.json");
				string json = await response.Content.ReadAsStringAsync();

				List<Predmet> predmeti = JsonConvert.DeserializeObject<List<Predmet>>(json);

				predmeti = predmeti?.Where(p => p != null).ToList();

				await Navigation.PushAsync(new NewPage1(predmeti));

		

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
