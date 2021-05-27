using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoFinOcupacionCanchaBasket : Evento
    {
        public override double generarTiempoEntreEventos()
        {
            return this.generador.generarVariableUniforme(70, 130);
        }

        public override string ToString()
        {
            return "Fin_ocupacion_cancha_basket";
        }
    }
}
