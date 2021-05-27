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
        protected double? random;
        protected double? tiempoEntreEventos;
        protected double? proximoEvento;
        protected GeneradorVariables generador;

        public double? Random { get => random; set => random = value; }
        public double? TiempoEntreEventos { get => tiempoEntreEventos; set => tiempoEntreEventos = value; }
        public double? ProximoEvento { get => proximoEvento; set => proximoEvento = value; }

        public void generarProximoEvento(double? reloj)
        {
            this.tiempoEntreEventos = this.generarTiempoEntreEventos();
            this.random = this.generador.LastRandom;
            this.proximoEvento = reloj + this.tiempoEntreEventos;
        }

        public void generarProximoEvento() => this.generarProximoEvento(this.proximoEvento == null? 0 : this.proximoEvento);

        public Evento()
        {
            this.proximoEvento = null;
            this.generador = new GeneradorVariables();
            this.random = null;
            this.tiempoEntreEventos = null;
        }

        public abstract double generarTiempoEntreEventos();
    }
}
