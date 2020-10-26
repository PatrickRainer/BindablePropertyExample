using System;

namespace BindablePropertyExample
{
    public partial class MainPage
    {
        Meeting _meeting;

        public MainPage()
        {
            InitializeComponent();

            Meeting = new Meeting
            {
                Subject = "A Meeting",
            };
        }

        public Meeting Meeting
        {
            get => _meeting;
            set
            {
                _meeting = value;
                OnPropertyChanged();
            }
        }

        void TimePickerPageButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TimePickerDemoPage());
        }
    }
}