using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindablePropertyExample
{
    public sealed class Meeting : INotifyPropertyChanged
    {
        string _subject;

        public string Subject
        {
            get => _subject;
            set
            {
                if (value == _subject) return;
                _subject = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}