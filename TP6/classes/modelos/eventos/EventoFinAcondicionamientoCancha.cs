using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.clientes;

namespace TP5.classes.modelos.eventos
{
    class EventoFinAcondicionamientoCancha : Evento
    {
        private double h;
        private Dictionary<Grupo.Disciplinas, double> D;
        private GestorIntegracionNumerica gestorIntegracion;

        private int C;
        private Grupo.Disciplinas disciplinaGrupo;
        private List<double?[]> procesoEuler;

        public List<double?[]> ProcesoEuler { get => procesoEuler; }

        public EventoFinAcondicionamientoCancha(double h, Dictionary<Grupo.Disciplinas, double> D)
        {
            this.h = h;
            this.D = D;
            gestorIntegracion = new GestorIntegracionNumerica(h);
        }

        public override double generarTiempoEntreEventos()
        {
            return this.gestorIntegracion.Integrar(this.C, D[this.disciplinaGrupo], out this.procesoEuler);
        }

        public void generarProximoEvento(double? reloj, int C, Grupo.Disciplinas disciplinaGrupo)
        {
            this.C = C;
            this.disciplinaGrupo = disciplinaGrupo;
            base.generarProximoEvento(reloj);
        }

        public override void borrarDatosTemporales()
        {
            base.borrarDatosTemporales();
            this.procesoEuler = null;
        }

        public override string ToString()
        {
            return "Fin_acond_cancha";
        }
    }
}
