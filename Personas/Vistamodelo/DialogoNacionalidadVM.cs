using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Personas.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personas
{
    class DialogoNacionalidadVM : ObservableRecipient
    {
        private string _nacionalidad;

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { SetProperty(ref _nacionalidad, value); }
        }


        public DialogoNacionalidadVM()
        {
            Nacionalidad = string.Empty;
        }

        public void Aceptar()
        {
            // Difunde el mensaje NuevaNacionalidadMessage con la nueva nacionalidad.
            WeakReferenceMessenger.Default.Send(new NuevaNacionalidadMessage(Nacionalidad));
        }
    }
}
