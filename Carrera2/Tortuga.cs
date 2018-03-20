using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera2
{
    class Tortuga : Competidor
    {
        private Random _generador;
        private String _nombre;
        private int _posicion;

        public Tortuga(String nombre) : base(nombre)
        {
        }

        public override int Avanzar()
        {
            _generador = new Random(DateTime.Now.Millisecond);
            int valor = _generador.Next(1, 11);

            if (valor <= 2)
                return 0;
            else if (valor <= 4)
                return 9;
            else if (valor <= 5)
                return -12;
            else if (valor <= 8)
                return 1;
            else
                return -2;
        }
    }
}
