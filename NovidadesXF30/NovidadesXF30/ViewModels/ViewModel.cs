using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NovidadesXF30.ViewModels
{
    public abstract class ViewModel
    {
        protected async Task NavigateTo(Type type, bool modal = false)
        {
            var mainPage = App.Current.MainPage as MasterDetailPage;
            mainPage.IsPresented = false;
            var page = Activator.CreateInstance(type) as ContentPage;
            await mainPage.Detail.Navigation.PushAsync(page);
        }
    }
}
