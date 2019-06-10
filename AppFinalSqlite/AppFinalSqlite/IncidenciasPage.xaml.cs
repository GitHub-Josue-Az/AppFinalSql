using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppFinalSqlite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IncidenciasPage : ContentPage
	{
		public IncidenciasPage ()
		{
			InitializeComponent ();
		}


        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (Incidencias)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }


        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (Incidencias)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }


        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        

    }
}