using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera2
{
    class Carrera
    {
        private Liebre _liebre;
        private Tortuga _tortuga;

        public Carrera(String nombreLiebre, String nombreTortuga)
        {
            _liebre = new Liebre(nombreLiebre);
            _tortuga = new Tortuga(nombreTortuga);
        }

        public String GenerarCarrera()
        {
            String resultado = "";
            while(_liebre.Posicion < 80 && _tortuga.Posicion < 80)
            {
                _liebre.Avanzar();
                resultado += _liebre.Nombre + " está en " + _liebre.Posicion + Environment.NewLine;
                _tortuga.Avanzar();
                resultado += _tortuga.Nombre + " está en " + _tortuga.Posicion + Environment.NewLine;
            }

            if (_liebre.Posicion > _tortuga.Posicion)
                resultado += _liebre.Nombre + " ganó.";
            else if (_liebre.Posicion == _tortuga.Posicion)
                resultado += "Existe un empate";
            else
                resultado += _tortuga.Nombre + " ganó.";

            return resultado;
        }
    }
}
