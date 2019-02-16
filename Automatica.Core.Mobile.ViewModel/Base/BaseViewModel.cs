using System.ComponentModel;
using System.Runtime.CompilerServices;
using Automatica.Core.Mobile.ViewModel.Annotations;

namespace Automatica.Core.Mobile.ViewModel.Base
{
    public class BaseViewModel  : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
