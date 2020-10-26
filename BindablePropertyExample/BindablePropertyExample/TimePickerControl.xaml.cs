using System;
using Syncfusion.XForms.Pickers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindablePropertyExample
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

        static void TimeSpanPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var control = (TimePickerControl) bindable;
            control.TimeEntry.Text = ((TimeSpan) newvalue).ToString(@"hh\:mm");
            control.TimePicker.Time = (TimeSpan) newvalue;
        }

        void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            TimePicker.IsOpen = true;
        }

        void TimePicker_OnTimeSelected(object sender, TimeChangedEventArgs e)
        {
            Time = (TimeSpan) e.NewValue;
        }
    }
}