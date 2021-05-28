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
        private float tiempoComienzoJuego;

        public Grupo(uint nro, Disciplinas disc, EstadoGrupo estado, float llegada)
            : this(nro, disc, estado, llegada, 0) 
        { }
        public Grupo(uint nro, Disciplinas disc, EstadoGrupo estado, float llegada, float comienzo)
        {
            this.numero = nro;
            this.disciplina = disc;
            this.estado = estado;
            this.horaLlegada = llegada;
            this.tiempoComienzoJuego = comienzo;
        }

        public uint Numero { get => numero; set => numero = value; }
        public Disciplinas Disciplina { get => disciplina; set => disciplina = value; }
        public float HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public float TiempoComienzoJuego { get => tiempoComienzoJuego; set => tiempoComienzoJuego = value; }
        internal EstadoGrupo Estado { get => estado; set => estado = value; }

        public bool EsBasket() => disciplina == Grupo.Disciplinas.Basketball;
        public bool EsFutbol() => disciplina == Grupo.Disciplinas.Futbol;
        public bool EsHandball() => disciplina == Grupo.Disciplinas.Handball;

        public void EsperarCancha() { Estado.EsperarCancha(this); }
        public void EmpezarJugar(float tiempoComienzoJuego) { 
            Estado.EmpezarAJugar(this); 
            this.tiempoComienzoJuego = tiempoComienzoJuego;
        }

    }
}
