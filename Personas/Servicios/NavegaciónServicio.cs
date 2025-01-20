using Personas.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Personas
{
    class NavegaciónServicio
    {
        private static readonly UserControl VistaListadoPersonas = new ListadoPersonasUserControl();

        private static readonly UserControl VistaNuevaPersona = new NuevaPersonaUserControl();

        public NavegaciónServicio()
        {
            
        }

        /* Llamar a las diferentes VISTAS: User-Control, Ventanas, Diálogos...*/
        public UserControl ObtenerNuevaPersona()
        {
            return VistaNuevaPersona;
        }

        public UserControl ObtenerListadoPersonas()
        {
            return VistaListadoPersonas;
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogo = new DialogoNacionalidad();
            return dialogo.ShowDialog();
        }

        public UserControl ObtenerConsultaPersona()
        {
            return new ConsultaPersonaUserControl();
        }
    }
}
