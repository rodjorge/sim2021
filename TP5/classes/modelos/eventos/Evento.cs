using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_tp3;

namespace TP5.classes.modelos.eventos
{
    abstract class Evento
    {
        protected double random;
        protected double tiempoEntreEventos;
        protected double proximoEvento;
        protected GeneradorVariables generador;

        public void generarProximoEvento(double reloj)
        {
            this.tiempoEntreEventos = this.generarTiempoEntreEventos();
            this.random = this.generador.LastRandom;
            this.proximoEvento = reloj + this.tiempoEntreEventos;
        }

        public void generarProximoEvento() => this.generarProximoEvento(this.proximoEvento);

        public Evento()
        {
            this.proximoEvento = 0;
            this.generador = new GeneradorVariables();
        }

        public abstract double generarTiempoEntreEventos();
    }
}
