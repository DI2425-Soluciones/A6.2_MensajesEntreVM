using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Personas.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vistamodelo
{
    class ConsultaPersonaUserControlVM : ObservableRecipient
    {
        private Persona _personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return _personaSeleccionada; }
            set { SetProperty(ref _personaSeleccionada, value); }
        }

        public ConsultaPersonaUserControlVM()
        {
            // Solicita la información de la persona seleccionada de la lista de personas.
            PersonaSeleccionada = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaMessage>();
        }
    }
}
