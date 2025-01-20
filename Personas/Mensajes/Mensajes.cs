using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Mensajes
{
    // Mensaje DIFUSIÓN para añadir una nueva nacionalidad.
    public class NuevaNacionalidadMessage : ValueChangedMessage<string>
    {
        public NuevaNacionalidadMessage(string nuevaNacionalidad) : base(nuevaNacionalidad) { }
    }

    // Mensaje DIFUSIÓN para añadir una nueva persona a la lista.
    public class NuevaPersonaMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaMessage(Persona nuevaPersona) : base(nuevaPersona) { }
    }

    // Mensaje SOLICITUD para obtener la persona seleccionada de una lista.
    public class PersonaSeleccionadaMessage : RequestMessage<Persona> { }
}

