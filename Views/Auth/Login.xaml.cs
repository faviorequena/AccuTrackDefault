using AccuTrackDefault.Views.Main;
using System.Text.Json;

namespace AccuTrackDefault.Views.Auth;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void LoginOnClick(object sender, EventArgs e)
    {
        string userName = txtUsername.Text;
        string password = txtPassword.Text;

        if (userName == null || password == null)
        {
            DisplayAlert("Warning", "Please input username and password", "Ok");
            return;
        }

        await Navigation.PushAsync(new MainMenu());

        //var apiResponse = await _loginRepository.Login(userName, password);

        //OauthTokenResponse tokenResponse = null;

        //if (!string.IsNullOrEmpty(apiResponse))
        //{
        //    var tokenJsonDoc = JsonDocument.Parse(apiResponse);
        //    if (tokenJsonDoc.RootElement.TryGetProperty("access_token", out _))
        //    {
        //        tokenResponse = JsonSerializer.Deserialize<OauthTokenResponse>(apiResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        //        await Navigation.PushAsync(new MainPage());
        //    }
        //    else
        //    {
        //        DisplayAlert("Warning", "Username or password is incorrect", "Ok");
        //    }
        //}
        //else
        //{
        //    DisplayAlert("Warning", "Username or password is incorrect", "Ok");
        //}

    }
}