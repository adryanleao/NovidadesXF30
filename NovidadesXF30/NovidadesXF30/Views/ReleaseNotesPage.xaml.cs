using System;

using Xamarin.Forms;

namespace NovidadesXF30.Views
{
    public partial class ReleaseNotesPage : ContentPage
    {
        public ReleaseNotesPage()
        {
            InitializeComponent();

            this.vejaMais.Clicked += (sender, e) => {
                Device.OpenUri(new Uri("https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.0/3.0.0/"));
            };
        }
    }
}