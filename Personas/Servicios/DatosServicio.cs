using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Personas
{
    class DatosServicio
    {
        public static ObservableCollection<Persona> ObtenerPersonas() => new ObservableCollection<Persona> {
                new Persona("Pietro", 30, "Italiana"),
                new Persona("Julia", 25, "Española"),
                new Persona("Sophie", 35, "Francesa")
        };

        public static ObservableCollection<string> ObtenerNacionalidades() => new ObservableCollection<string> {"Italiana", "Española", "Francesa"};
    }
}
