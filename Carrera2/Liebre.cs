using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera2
{
    class Liebre : Competidor
    {
        private Random _generador;
        private String _nombre;
        private int _posicion;

        public Liebre(String nombre) : base(nombre)
        {
        }

        public override int Avanzar()
        {
            _generador = new Random(DateTime.Now.Millisecond);
            int valor = _generador.Next(1, 11);

            if (valor <= 2)
                return -6;
            else if (valor <= 5)
                return 1;
            else
                return 3;
        }

    }
}
