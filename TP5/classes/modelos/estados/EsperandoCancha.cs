using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.clientes;

namespace TP5.classes.modelos.estados
{
    class EsperandoCancha: EstadoGrupo
    {
        public static EsperandoCancha Instancia { get; } = new EsperandoCancha();
        private EsperandoCancha() 
        {
            this.Nombre = "Esperando Cancha";
            this.Descripcion = "El grupo esta esperando que una cancha se desocupe";
        }

        public override void EsperarCancha(Grupo grupo)
        {
            return;
        }

        public override void EmpezarAJugar(Grupo grupo)
        {
            grupo.Estado = CrearJugando();
        }

        public override bool EsEsperandoCancha()
        {
            return true;
        }

        public override bool EsJugando()
        {
            return false;
        }

        private Jugando CrearJugando()
        {
            return Jugando.Instancia;
        }
    }
}
