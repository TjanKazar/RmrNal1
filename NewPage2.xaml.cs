namespace RmrNal1;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

	private async void OnContactButtonClicked(object sender, EventArgs e)
	{
		await DisplayAlert("Contact", "Thank you for your interest! Please email us at contact@example.com", "OK");
	}
}