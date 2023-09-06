using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoFinOcupacionCanchaFutbol : EventoConNormal
    {


        public EventoFinOcupacionCanchaFutbol(double media, double desviacion) : base(media, desviacion)
        {

        }

        

        public override string ToString()
        {
            return "Fin_ocupacion_cancha_futbol";
        }

    }
}
