using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.servidores;

namespace TP5.classes.modelos.estados
{
    abstract class EstadoCancha: Estado
    {

        public abstract void LiberarCancha(Cancha cancha);
        public abstract void OcuparCancha(Cancha cancha);
        public abstract void AcondicionarCancha(Cancha cancha);

        public abstract bool EstaOcupada();
        public abstract bool EstaLibre();
        public abstract bool EstaEnAcondicionamiento();
    }
}
