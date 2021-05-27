using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.eventos;
using TP5.classes.modelos.servidores;
using TP5.classes.modelos.clientes;

namespace TP5.classes
{
    class GestorSimulacion
    {
        private double relojMin;
        private object[] ultimoVectorEstado = new object[35];
        private List<Evento> eventos;
        private Cancha cancha;
        private int contadorGruposBasket, contadorGruposFutbol, contadorGruposHandball;
        private double acumEsperaGruposBasket, acumEsperaGruposFutbol, acumEsperaGruposHandball;
        private double acumOcupacionCancha;
        private double acumOcupacionCanchaBasket, acumOcupacionCanchaFutbol, acumOcupacionCanchaHandball;

        public List<object[]> simular(double tiempo, int iteraciones) => simular(tiempo, iteraciones, -1, 0);
        public List<object[]> simular(double tiempo, int iteraciones, double horaVerDesde, int iteracionesVerHasta)
        {
            //Inicializacion

            this.relojMin = 0;
            contadorGruposBasket = contadorGruposFutbol = contadorGruposHandball = 0;
            acumEsperaGruposBasket = acumEsperaGruposFutbol = acumEsperaGruposHandball = 0;
            acumOcupacionCancha = 0;
            acumOcupacionCanchaBasket = acumOcupacionCanchaFutbol = acumOcupacionCanchaHandball = 0;

            this.eventos.Add(new EventoFinAcondicionamientoCancha());
            this.eventos.Add(new EventoLlegadaGrupoBasket());
            this.eventos.Add(new EventoLlegadaGrupoFutbol());
            this.eventos.Add(new EventoLlegadaGrupoHandball());
            this.eventos.Add(new EventoFinOcupacionCanchaBasket());
            this.eventos.Add(new EventoFinOcupacionCanchaFutbol());
            this.eventos.Add(new EventoFinOcupacionCanchaHandball());

            //Generacion de tiempos de llegada
            this.eventos[1].generarProximoEvento();
            this.eventos[2].generarProximoEvento();
            this.eventos[3].generarProximoEvento();

            //Armado del primer vector estado
            this.ultimoVectorEstado[0] = "Inicializacion";
            this.ultimoVectorEstado[1] = this.relojMin;
            this.ultimoVectorEstado[2] = this.eventos[0].ProximoEvento;
            int lastIndex = 2;
            foreach (Evento evento in this.eventos.Skip(1))
            {
                this.ultimoVectorEstado[lastIndex + 1] = evento.Random;
                this.ultimoVectorEstado[lastIndex + 2] = evento.TiempoEntreEventos;
                this.ultimoVectorEstado[lastIndex + 3] = evento.ProximoEvento;
                lastIndex += 3;
            }
            this.ultimoVectorEstado[22] = this.cancha.Estado.Nombre;
            this.ultimoVectorEstado[23] = this.cancha.ColaGrupos.Count;
            this.ultimoVectorEstado[24] = this.contadorGruposBasket;
            this.ultimoVectorEstado[25] = this.contadorGruposFutbol;
            this.ultimoVectorEstado[26] = this.contadorGruposHandball;
            this.ultimoVectorEstado[27] = this.acumEsperaGruposBasket;
            this.ultimoVectorEstado[28] = this.acumEsperaGruposFutbol;
            this.ultimoVectorEstado[29] = this.acumEsperaGruposHandball;
            this.ultimoVectorEstado[30] = this.acumOcupacionCancha;
            this.ultimoVectorEstado[31] = this.acumOcupacionCanchaBasket;
            this.ultimoVectorEstado[32] = this.acumOcupacionCanchaFutbol;
            this.ultimoVectorEstado[33] = this.acumOcupacionCanchaHandball;

            this.ultimoVectorEstado[34] = new List<object[]>(); //El ultimo indice del vector estado corresponde a una lista dinamica con datos de los grupos


            //Creacion de lista de vectores estado que seran almacenados y mostrados (incluyendo el último vector estado)
            List<object[]> vectoresEstadoPersistentes = new List<object[]>();


            //Simulacion

            //Retorno de los vectores estado persistentes para el form
            return vectoresEstadoPersistentes;
        }
    }
}
