using AirePuro.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirePuro.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginConteniddo : ContentPage
	{
		public LoginConteniddo()
		{
			InitializeComponent ();
            BindingContext = new VMLogin(Navigation);
        }
	}
}