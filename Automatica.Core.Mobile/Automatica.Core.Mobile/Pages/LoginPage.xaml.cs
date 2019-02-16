using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Automatica.Core.Mobile.View;
using Automatica.Core.Mobile.ViewModel.Login;
using Xamarin.Forms;

namespace Automatica.Core.Mobile.Pages
{
    public partial class LoginPage : ContentPage, ILoginView
    {
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new LoginPageViewModel(this);
        }
    }
}
