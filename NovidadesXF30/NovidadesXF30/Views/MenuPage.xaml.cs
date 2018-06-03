using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NovidadesXF30.Views
{
	public partial class MenuPage : ContentPage
	{
        private ViewModels.MenuViewModel _viewModel = new ViewModels.MenuViewModel();

        public MenuPage ()
		{
			InitializeComponent ();

            this.BindingContext = this._viewModel;
        }
    }
}