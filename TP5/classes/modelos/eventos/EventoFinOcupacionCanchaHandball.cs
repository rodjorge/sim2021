using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoFinOcupacionCanchaHandball : Evento
    {
        public override double generarTiempoEntreEventos()
        {
            return this.generador.generarVariableNormal(80, 20)[0];
        }

        public override string ToString()
        {
            return "Fin_ocupacion_cancha_handball";
        }
    }
}
