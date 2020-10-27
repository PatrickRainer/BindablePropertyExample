using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindablePropertyExample.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerControl
    {
        public static readonly BindableProperty TimeProperty = BindableProperty.Create(
            nameof(Time), typeof(TimeSpan), typeof(TimePickerControl),
            new TimeSpan(), BindingMode.TwoWay, null, TimeSpanPropertyChanged);

        public TimePickerControl()
        {
            InitializeComponent();
        }

        public TimeSpan Time
        {
            get => (TimeSpan) GetValue(TimeProperty);
            set => SetValue(TimeProperty, value);
        }

        static void TimeSpanPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            /*var control = (TimePickerControl) bindable;
            control.TimeEntry.Text = ((TimeSpan) newValue).ToString(@"hh\:mm");
            control.TimePicker.Time = (TimeSpan) newValue;*/
        }

        void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            TimePicker.IsOpen = true;
        }
    }
}