using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoLlegadaGrupoFutbol : Evento
    {
        public override double generarTiempoEntreEventos()
        {
            return this.generador.generarVariableExponencialConLambda(600);
        }
        public override string ToString()
        {
            return "Llegada_grupo_futbol";
        }
    }
}
