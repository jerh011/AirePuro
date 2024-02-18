using AirePuro.View;
using AirePuro.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AirePuro
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
       
            this.Master=new MenuLateral();
            this.Detail = new NavigationPage(new LoginConteniddo());
            App.MasterDet = this;
        }
    }
}
