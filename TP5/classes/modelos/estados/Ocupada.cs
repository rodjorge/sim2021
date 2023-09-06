using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.servidores;

namespace TP5.classes.modelos.estados
{
    class Ocupada: EstadoCancha
    {
        public static Ocupada Instancia { get; } = new Ocupada();
        private Ocupada() 
        {
            this.Nombre = "Ocupada";
            this.Descripcion = "La cancha está siendo ocupada por un grupo";
        }

        public override void AcondicionarCancha(Cancha cancha)
        {
            cancha.Estado = CrearEnAcondicionamiento();
        }

        public override bool EstaEnAcondicionamiento()
        {
            return false;
        }

        public override bool EstaLibre()
        {
            return false;
        }

        public override bool EstaOcupada()
        {
            return true;
        }

        public override void LiberarCancha(Cancha cancha)
        {
            cancha.Estado = CrearLibre();
        }

        public override void OcuparCancha(Cancha cancha)
        {
            return; 
        }

        private EnAcondicionamiento CrearEnAcondicionamiento() 
        {
            return EnAcondicionamiento.Instancia;
        }

        private Libre CrearLibre()
        {
            return Libre.Instancia;
        }
    }
}
