﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindablePropertyExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeetingControl
    {
        public static readonly BindableProperty SubjectProperty =
            BindableProperty.Create(nameof(Subject), typeof(string), typeof(MeetingControl), "default",
                BindingMode.TwoWay, null, PropertyChanged);

        public MeetingControl()
        {
            InitializeComponent();
            SubjectEntry.TextChanged += SubjectEntryOnTextChanged;
        }

        public string Subject
        {
            get { return (string) GetValue(SubjectProperty); }
            set { SetValue(SubjectProperty, value); }
        }

        static void PropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var str = (string) newvalue;
            var control = (MeetingControl) bindable;
            control.SubjectEntry.Text = str;
        }

        void SubjectEntryOnTextChanged(object sender, TextChangedEventArgs e)
        {
            Subject = e.NewTextValue;
        }
    }
}