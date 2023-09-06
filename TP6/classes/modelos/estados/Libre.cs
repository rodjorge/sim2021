using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.servidores;

namespace TP5.classes.modelos.estados
{
    class Libre : EstadoCancha
    {
        public static Libre Instancia { get; } = new Libre();
        private Libre()
        {
            this.Nombre = "Libre";
            this.Descripcion = "La cancha está libre y a la espera de un grupo";
        }

        public override void AcondicionarCancha(Cancha cancha)
        {
            throw new NotSupportedException();
        }

        public override bool EstaEnAcondicionamiento()
        {
            return false;
        }

        public override bool EstaLibre()
        {
            return true;
        }

        public override bool EstaOcupada()
        {
            return false;
        }

        public override void LiberarCancha(Cancha cancha)
        {
            return;
        }

        public override void OcuparCancha(Cancha cancha)
        {
            cancha.Estado = CrearOcupada();
        }

        private Ocupada CrearOcupada() 
        {
            return Ocupada.Instancia;
        }
    }
}
