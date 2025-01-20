using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Personas.Mensajes;
using System.Collections.ObjectModel;
using System.Windows;

namespace Personas
{
    class ListadoPersonasUserControlVM : ObservableRecipient
    {
        private ObservableCollection<Persona> _listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return _listaPersonas; }
            set { SetProperty(ref _listaPersonas, value); }
        }

        private Persona _personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return _personaSeleccionada; }
            set { SetProperty(ref _personaSeleccionada, value); }
        }

        public ListadoPersonasUserControlVM()
        {
            ListaPersonas = DatosServicio.ObtenerPersonas();

            // Registra el mensaje "NuevaPersonaMessage" para añadir una nueva persona a la lista de personas.
            WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>(this, (r, m) =>
            {
                ListaPersonas.Add(m.Value);

                MessageBox.Show("Persona añadida correctamente", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            });

            // Responde al mensaje "PersonaSeleccionadaMessage" con la persona seleccionada de la lista de personas.
            WeakReferenceMessenger.Default.Register<ListadoPersonasUserControlVM, PersonaSeleccionadaMessage>(this, (r, m) =>
            {
                if (!m.HasReceivedResponse) { 
                    m.Reply(r.PersonaSeleccionada);
                }
            });

        }
    }
}
