using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoFinAcondicionamientoCancha : Evento
    {
        public override double generarTiempoEntreEventos()
        {
            return 10;
        }

        public override string ToString()
        {
            return "Fin_acond_cancha";
        }
    }
}
