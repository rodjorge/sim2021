using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoFinAcondicionamientoCancha : Evento
    {
        private double demora;

        public EventoFinAcondicionamientoCancha(double demora)
        {
            this.demora = demora;
        }

        public override double generarTiempoEntreEventos()
        {
            return this.demora;
        }

        public override string ToString()
        {
            return "Fin_acond_cancha";
        }
    }
}
