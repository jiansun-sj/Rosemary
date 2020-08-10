using System.ComponentModel;

namespace RosemaryThemes.Wpf.Model
{
    public interface IUser : INotifyPropertyChanged
    {
        string UserName { get; set; }

        string Password { get; set; }

        UserAuthority Authority { get; set; }

    }
}
