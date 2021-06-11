using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoLlegadaGrupoBasket : Evento
    {
        private double media, desviacion;

        public EventoLlegadaGrupoBasket(double media, double desviacion)
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
            return "Llegada_grupo_basket";
        }
    }
}
