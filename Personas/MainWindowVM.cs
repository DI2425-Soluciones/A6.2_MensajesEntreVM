using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        private NavegaciónServicio navegacion;

        public RelayCommand AbrirNuevaPersonaCommand { get; }
        public RelayCommand AbrirListadoPersonasCommand { get; }
        public RelayCommand AbrirConsultaPersonaCommand { get; }

        private UserControl _contenidoVentana;
        public UserControl ContenidoVentana
        {
            get { return _contenidoVentana; }
            set { SetProperty(ref _contenidoVentana, value); }
        }

        public MainWindowVM()
        {
            navegacion = new NavegaciónServicio();
                        
            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);
            AbrirListadoPersonasCommand = new RelayCommand(AbrirListadoPersonas);
            AbrirConsultaPersonaCommand = new RelayCommand(AbrirConsultaPersona);
        }

        private void AbrirNuevaPersona()
        {
            ContenidoVentana = navegacion.ObtenerNuevaPersona();
        }

        private void AbrirListadoPersonas()
        {
            ContenidoVentana = navegacion.ObtenerListadoPersonas();
        }

        private void AbrirConsultaPersona()
        {
            ContenidoVentana = navegacion.ObtenerConsultaPersona();
        }
    }
}
