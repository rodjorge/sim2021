using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoLlegadaGrupoHandball : Evento
    {
        private double media, desviacion;

        public EventoLlegadaGrupoHandball(double media, double desviacion)
        {
            this.media = media;
            this.desviacion = desviacion;
        }

        public override double generarTiempoEntreEventos()
        {
            return this.generador.generarVariableNormal(this.media, this.desviacion)[0];
        }

        public override string ToString()
        {
            return "Llegada_grupo_handball";
        }
    }
}
