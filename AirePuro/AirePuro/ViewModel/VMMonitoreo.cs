using AirePuro.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AirePuro.ViewModel
{
    public class VMMonitoreo : BaseViewModel
    {
        public VMMonitoreo(INavigation naivigation)
        {
            Navigation = naivigation;

        }

        #region Procesos
     
        //public async Task IncioSecion()
        //{

        //    await Navigation.PushAsync(new Pruevas());
        //}
        #endregion




        #region Comandos

      //  public ICommand Monitoreocommand => new Command(async () => await IncioSecion());
        #endregion
    }
}
