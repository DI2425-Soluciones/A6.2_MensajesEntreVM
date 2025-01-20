using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Personas
{
    public class Persona : ObservableObject
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }
        }

        private int? _edad;

        public int? Edad
        {
            get { return _edad; }
            set { SetProperty(ref _edad, value); }
        }

        private string _nacionalidad;

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { SetProperty(ref _nacionalidad, value); }
        }

        public Persona(string nombre, int edad, string nacionalidad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacionalidad = nacionalidad;
        }
    }
}
