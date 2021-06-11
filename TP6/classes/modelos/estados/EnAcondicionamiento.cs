using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.servidores;

namespace TP5.classes.modelos.estados
{
    class EnAcondicionamiento : EstadoCancha
    {
        public static EnAcondicionamiento Instancia { get; } = new EnAcondicionamiento();
        private EnAcondicionamiento()
        {
            this.Nombre = "En Acondicionamiento";
            this.Descripcion = "La cancha está siendo acondicionada para la proxima disciplina";
        }

        public override void AcondicionarCancha(Cancha cancha)
        {
            return;
        }

        public override bool EstaEnAcondicionamiento()
        {
            return true;
        }

        public override bool EstaLibre()
        {
            return false;
        }

        public override bool EstaOcupada()
        {
            return false;
        }

        public override void LiberarCancha(Cancha cancha)
        {
            cancha.Estado = CrearLibre();
        }

        public override void OcuparCancha(Cancha cancha)
        {
            cancha.Estado = CrearOcupada();
        }

        private Libre CrearLibre() 
        {
            return Libre.Instancia;
        }

        private Ocupada CrearOcupada() 
        {
            return Ocupada.Instancia;
        }
    }
}
