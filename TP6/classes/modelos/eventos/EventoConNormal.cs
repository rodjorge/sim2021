using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoConNormal : Evento
    {
        protected double media, desviacion;
        private double? random2;
        protected List<double> variables;

        public double? Random2 { get => random2; set => random2 = value; }

        public EventoConNormal(double media, double desviacion)
        {
            this.media = media;
            this.desviacion = desviacion;
            this.variables = new List<double>();
            this.random2 = null;
        }
        public override double generarTiempoEntreEventos()
        {
            if (this.variables.Count == 0)
            {
                this.variables = this.generador.generarVariableNormal(this.media, this.desviacion, out double[] random);
                this.random = random[0];
                this.random2 = random[1];
            }

            double variable = this.variables[0];
            this.variables.RemoveAt(0);
            return variable;
        }
        public override void borrarDatosTemporales()
        {
            if(!this.tieneQueArrastrarRandoms())
            {
                this.random = null;
                this.random2 = null;
            }
            
            this.tiempoEntreEventos = null;
        }
        public bool tieneQueArrastrarRandoms() => this.variables.Count != 0;
        public override bool tieneDistribucionNormal() => true;
    }
}
