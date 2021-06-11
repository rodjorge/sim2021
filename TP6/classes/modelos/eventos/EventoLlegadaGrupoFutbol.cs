using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoLlegadaGrupoFutbol : Evento
    {
        private double lambda;

        public EventoLlegadaGrupoFutbol(double lambda)
        {
            this.lambda = lambda;
        }

        public override double generarTiempoEntreEventos()
        {
            double variable = this.generador.generarVariableExponencialConMedia(this.lambda, out double random);
            this.random = random;
            return variable;
        }
        public override string ToString()
        {
            return "Llegada_grupo_futbol";
        }
    }
}
