using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.clientes;

namespace TP5.classes.modelos.estados
{
    class Jugando: EstadoGrupo
    {
        public static Jugando Instancia { get; } = new Jugando();
        private Jugando()
        {
            this.Nombre = "Jugando";
            this.Descripcion = "El grupo esta jugando";
        }

        public override void EsperarCancha(Grupo grupo)
        {
            throw new NotSupportedException();
        }

        public override void EmpezarAJugar(Grupo grupo)
        {
            return;
        }

        public override bool EsEsperandoCancha()
        {
            return false;
        }

        public override bool EsJugando()
        {
            return true;
        }
    }
}
