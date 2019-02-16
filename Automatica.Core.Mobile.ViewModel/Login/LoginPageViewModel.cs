using System.Reflection;
using Automatica.Core.Mobile.View;
using Automatica.Core.Mobile.ViewModel.Base;

namespace Automatica.Core.Mobile.ViewModel.Login
{
    public class LoginPageViewModel : BaseViewModel
    {
        private readonly ILoginView _login;
        private string _username;
        private string _ipAddress;
        private string _password;

        public LoginPageViewModel(ILoginView login)
        {
            _login = login;
        }

        public string Username
        {
            get => _username;
            set
            {
                if (value == _username) return;
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value == _password) return;
                _password = value;
                OnPropertyChanged();
            }
        }

        public string IpAddress
        {
            get => _ipAddress;
            set
            {
                if (value == _ipAddress) return;
                _ipAddress = value;
                OnPropertyChanged();
            }
        }
    }
}
