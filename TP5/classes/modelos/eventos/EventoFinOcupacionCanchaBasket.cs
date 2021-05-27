using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoFinOcupacionCanchaBasket : Evento
    {
        private double limInf, limSup;

        public EventoFinOcupacionCanchaBasket(double centroIntervalo, double amplitudIntervalo)
        {
            this.limInf = centroIntervalo - amplitudIntervalo;
            this.limSup = centroIntervalo + amplitudIntervalo;
        }

        public override double generarTiempoEntreEventos()
        {
            return this.generador.generarVariableUniforme(this.limInf, this.limSup);
        }

        public override string ToString()
        {
            return "Fin_ocupacion_cancha_basket";
        }
    }
}
