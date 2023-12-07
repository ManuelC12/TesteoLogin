using System;
using System.Windows.Input;
using Testeo_Login.Views;
using Xamarin.Forms;

namespace Testeo_Login.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }

        private string username;
        private string password;
        private bool check;

        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public bool Check
        {
            get { return check; }
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (username == "ChanJuana" && password == "TacosDeSandia")
            {
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                check = true;
            }
            else if (username != "ChanJuana" || password != "TacosDeSandia")
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Inicio de sesión fallido posibles credenciales incorrectas", "OK");
                check = false;
            }
        }
    }
}
