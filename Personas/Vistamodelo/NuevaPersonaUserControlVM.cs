using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Personas.Mensajes;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Documents;

namespace Personas
{
    class NuevaPersonaUserControlVM : ObservableRecipient
    {
        private readonly NavegaciónServicio navegacion;

        private Persona _nuevaPersona;
        public Persona NuevaPersona
        {
            get { return _nuevaPersona; }
            set { SetProperty(ref _nuevaPersona, value); }
        }

        private ObservableCollection<string> _listaNacionalidades;
        public ObservableCollection<string> ListaNacionalidades
        {
            get { return _listaNacionalidades; }
            set { SetProperty(ref _listaNacionalidades, value); }
        }

        public RelayCommand AceptarNuevaPersonaCommand { get; }
        public RelayCommand NuevaNacionalidadCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            navegacion = new NavegaciónServicio();
            NuevaPersona = new Persona("",0,"Española");

            ListaNacionalidades = DatosServicio.ObtenerNacionalidades();

            AceptarNuevaPersonaCommand = new RelayCommand(AñadirPersona);
            NuevaNacionalidadCommand = new RelayCommand(AñadirNacionalidad);

            // Se suscribe al mensaje NuevaNacionalidadMessage para añadir la nueva nacionalidad a la lista.
            WeakReferenceMessenger.Default.Register<NuevaNacionalidadMessage>(this, (r, m) =>
            {
                ListaNacionalidades.Add(m.Value);

                MessageBox.Show("Se ha añadido una nueva nacionalidad.", "Nueva nacionalidad", MessageBoxButton.OK, MessageBoxImage.Information);
            });
        }

        private void AñadirNacionalidad()
        {
            // Para añadir una nueva nacionalidad, se abre un diálogo modal de nacionalidad.
            bool? resultado = navegacion.AbrirDialogoNacionalidad();
        }

        private void AñadirPersona()
        {
            // Difunde el mensaje "NuevaPersonaMessage" con la nueva persona.
            WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(NuevaPersona));

            // Inicializamos el formulario pero guardando listado de nacionalidades posibles.
            NuevaPersona = new Persona("", 0, "Española");
        }
    }
}
