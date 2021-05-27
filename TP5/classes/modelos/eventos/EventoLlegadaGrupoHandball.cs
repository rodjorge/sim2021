using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoLlegadaGrupoHandball : Evento
    {
        public override double generarTiempoEntreEventos()
        {
            return this.generador.generarVariableNormal(720, 120)[0];
        }

        public override string ToString()
        {
            return "Llegada_grupo_handball";
        }
    }
}
