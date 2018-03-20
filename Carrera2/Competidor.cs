using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera2
{
    abstract class Competidor
    {
        private String _nombre;
        private int _posicion;
        private Random _generador;

        public String Nombre
        {
            get { return _nombre; }
        }

        public int Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }

        public Competidor(String nombre)
        {
            _nombre = nombre;
            _posicion = 0;
        }

        public abstract int Avanzar();

        public String ImprimirPosicion()
        {
            return _nombre + " está en " + _posicion;
        }

    }
}
