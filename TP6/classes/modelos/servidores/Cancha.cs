﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.estados;
using TP5.classes.modelos.clientes;

namespace TP5.classes.modelos.servidores
{
    class Cancha
    {
        private readonly uint numero;
        private EstadoCancha estado;
        private Queue<Grupo> colaGrupos;
        private readonly List<Grupo> gruposJugando;

        public Cancha(uint nro) : this(nro, Libre.Instancia) { }
        public Cancha(uint nro, EstadoCancha estado)
        {
            this.numero = nro;
            this.estado = estado;
            colaGrupos = new Queue<Grupo>();
            gruposJugando = new List<Grupo>();
        }
        public uint Numero { get => numero; }
        public EstadoCancha Estado { get => estado; set => estado = value; }
        public Queue<Grupo> ColaGrupos { get => colaGrupos; set => colaGrupos = value; }

        public List<Grupo> GruposJugando => gruposJugando;

        public void LiberarCancha() { 
            Estado.LiberarCancha(this);
        }
        public void OcuparCancha() { Estado.OcuparCancha(this); }
        public void AcondicionarCancha() { Estado.AcondicionarCancha(this); }
        public bool EstaOcupada() => Estado.EstaOcupada();
        public bool EstaLibre() => Estado.EstaLibre();

        public void SacarEquiposCancha() => GruposJugando.Clear();
        public void SacarEquipoCancha(int index) => GruposJugando.RemoveAt(index);
    }
}
