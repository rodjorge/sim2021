using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.estados;

namespace TP5.classes.modelos.clientes
{
    class Grupo
    {
        public enum Disciplinas
        {
            Basketball, Futbol, Handball
        }

        private uint numero;
        private Disciplinas disciplina;
        private EstadoGrupo estado;
        private float horaLlegada;
        private float tiempoEspera;
        private float tiempoComienzoJuego;
        private float tiempoFinJuego;

        public Grupo(uint nro, Disciplinas disc, EstadoGrupo estado, float llegada)
            : this(nro, disc, estado, llegada, 0, 0, 0) 
        { }
        public Grupo(uint nro, Disciplinas disc, EstadoGrupo estado, float llegada, 
            float espera, float comienzo, float fin)
        {
            this.numero = nro;
            this.disciplina = disc;
            this.estado = estado;
            this.horaLlegada = llegada;
            this.tiempoEspera = espera;
            this.tiempoComienzoJuego = comienzo;
            this.tiempoFinJuego = fin;
        }

        public uint Numero { get => numero; set => numero = value; }
        public Disciplinas Disciplina { get => disciplina; set => disciplina = value; }
        public float HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public float TiempoEspera { get => tiempoEspera; set => tiempoEspera = value; }
        public float TiempoComienzoJuego { get => tiempoComienzoJuego; set => tiempoComienzoJuego = value; }
        public float TiempoFinJuego { get => tiempoFinJuego; set => tiempoFinJuego = value; }
        internal EstadoGrupo Estado { get => estado; set => estado = value; }

        public bool EsBasket() { return disciplina == Grupo.Disciplinas.Basketball; }

        public void EsperarCancha() { Estado.EsperarCancha(this); }
        public void EmpezarJugar() { Estado.EmpezarAJugar(this); }

    }
}
