using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoLlegadaGrupoBasket : EventoConNormal
    {

        public EventoLlegadaGrupoBasket(double media, double desviacion): base(media, desviacion)
        {
            
        }

        public override string ToString()
        {
            return "Llegada_grupo_basket";
        }
    }
}
