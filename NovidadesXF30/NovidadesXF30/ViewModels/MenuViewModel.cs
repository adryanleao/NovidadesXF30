using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NovidadesXF30.ViewModels
{
    public class MenuViewModel : ViewModel
    {
        public Command MenuItemCommand { get; set; }

        public MenuViewModel()
        {
            this.MenuItemCommand = new Command(async (obj) => await this.MenuItem(obj));
        }

        private async Task MenuItem(object obj)
        {
            if (obj is Type type)
                await this.NavigateTo(type);
        }
    }
}
