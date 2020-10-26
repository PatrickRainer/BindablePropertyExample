using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindablePropertyExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerDemoPage : ContentPage
    {
        TimeSpan _myTime;

        public TimePickerDemoPage()
        {
            InitializeComponent();
            MyTime = DateTime.Now.TimeOfDay;
        }

        public TimeSpan MyTime
        {
            get => _myTime;
            set
            {
                _myTime = value;
                OnPropertyChanged();
            }
        }
    }
}