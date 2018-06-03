using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NovidadesXF30.Views
{
	public partial class VisualStateManagerPage : ContentPage
	{
		public VisualStateManagerPage()
		{
			InitializeComponent ();

            this.button.Clicked += (sender, e) =>
            {
                VisualStateManager.GoToState(this.entry, "myState");
            };
        }
    }
}