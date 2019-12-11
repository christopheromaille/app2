using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Start : ContentPage
	{
		public Start ()
		{
			InitializeComponent ();
		}
        private async void button_ClickedStart(Object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
	}
}