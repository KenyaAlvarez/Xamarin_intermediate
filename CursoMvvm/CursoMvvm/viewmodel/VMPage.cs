using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CursoMvvm.viewmodel
{
    public class VMPage : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        #endregion

        #region CONSTRUCTOR
        public VMPage(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Alerta()
        {
            await DisplayAlert("Titutlo", Mensaje, "OK");
        }

        public void ProcesoSimple()
        {
            
        }
        #endregion

        #region COMANDOS
        public ICommand Alertacommand => new Command(async () => await Alerta());
        public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);
        #endregion
    }
}

