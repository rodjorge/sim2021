using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.eventos;
using TP5.classes.modelos.servidores;
using TP5.classes.modelos.clientes;
using TP5.classes.modelos.estados;


namespace TP5.classes
{
    class GestorSimulacion
    {
        private float relojMin;
        private object[] ultimoVectorEstado = new object[35];
        private List<Evento> eventos;
        private Cancha cancha;
        private int[] contadores;
        private double[] acumuladoresEspera;
        private double acumOcupacionCancha;
        private double[] acumuladoresOcupacion;

        uint lastNroCliente = 1;
        Grupo.Disciplinas[] disciplinas = new Grupo.Disciplinas[] { Grupo.Disciplinas.Basketball, Grupo.Disciplinas.Futbol, Grupo.Disciplinas.Handball };

        public List<object[]> simular(double tiempo, int iteraciones, double[][] paramsEventos) => simular(tiempo, iteraciones, paramsEventos, -1, 0);
        public List<object[]> simular(double tiempo, int iteraciones, double[][] paramsEventos, double horaVerDesde, int iteracionesVerHasta)
        {
            //Inicializacion

            this.relojMin = 0;
            this.contadores = new int[] { 0, 0, 0 };
            this.acumuladoresEspera = new double[] { 0, 0, 0 };
            this.acumOcupacionCancha = 0;
            this.acumuladoresOcupacion = new double[] { 0, 0, 0 };

            this.eventos.Add(new EventoFinAcondicionamientoCancha(paramsEventos[0][0]));
            this.eventos.Add(new EventoLlegadaGrupoBasket(paramsEventos[1][0], paramsEventos[1][1]));
            this.eventos.Add(new EventoLlegadaGrupoFutbol(paramsEventos[2][0]));
            this.eventos.Add(new EventoLlegadaGrupoHandball(paramsEventos[3][0], paramsEventos[3][1]));
            this.eventos.Add(new EventoFinOcupacionCanchaBasket(paramsEventos[4][0], paramsEventos[4][1]));
            this.eventos.Add(new EventoFinOcupacionCanchaFutbol(paramsEventos[5][0], paramsEventos[5][1]));
            this.eventos.Add(new EventoFinOcupacionCanchaHandball(paramsEventos[6][0], paramsEventos[6][1]));

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
            this.ultimoVectorEstado[24] = this.contadores[0];
            this.ultimoVectorEstado[25] = this.contadores[1];
            this.ultimoVectorEstado[26] = this.contadores[2];
            this.ultimoVectorEstado[27] = this.acumuladoresEspera[0];
            this.ultimoVectorEstado[28] = this.acumuladoresEspera[1];
            this.ultimoVectorEstado[29] = this.acumuladoresEspera[2];
            this.ultimoVectorEstado[30] = this.acumOcupacionCancha;
            this.ultimoVectorEstado[31] = this.acumuladoresOcupacion[0];
            this.ultimoVectorEstado[32] = this.acumuladoresOcupacion[1];
            this.ultimoVectorEstado[33] = this.acumuladoresOcupacion[2];

            this.ultimoVectorEstado[34] = new List<object[]>(); //El ultimo indice del vector estado corresponde a una lista dinamica con datos de los grupos

            iteraciones--;

            //Creacion de lista de vectores estado que seran almacenados y mostrados (incluyendo el último vector estado)
            List<object[]> vectoresEstadoPersistentes = new List<object[]>();

            //Si se quiere ver las filas desde que el reloj marca 0, se incluye tambien el vector de estado de inicializacion
            if(horaVerDesde == 0)
            {
                vectoresEstadoPersistentes.Add(this.ultimoVectorEstado);
                iteracionesVerHasta--;
            }


            //Simulacion


            for (int i = 0; i < iteraciones; i++)
            {
                int indexProxEvento = this.decidirProximoEvento();
                this.relojMin = (float)this.eventos[indexProxEvento].ProximoEvento;

                if (tiempo < this.relojMin)
                    break;

                switch (indexProxEvento)
                {
                    case 0:
                        //Caso acondicionamiento
                        this.eventos[indexProxEvento].borrarProximoEvento();
                        if(this.cancha.ColaGrupos.Count != 0)
                        {
                            //Se hace pasar al siguiente grupo de la cola

                        }
                        else
                        {
                            this.cancha.LiberarCancha();
                        }
                        break;

                    case 1:
                    case 2:
                    case 3:
                        //Caso llegada
                        this.eventos[indexProxEvento].generarProximoEvento();
                        Grupo nuevoGrupo = new Grupo(this.lastNroCliente++, this.disciplinas[indexProxEvento - 1], EsperandoCancha.Instancia, this.relojMin);
                        if(this.cancha.EstaLibre() && (!nuevoGrupo.EsBasket() || this.cancha.ColaGrupos.Peek().EsBasket()))
                        {
                            nuevoGrupo.EmpezarJugar(this.relojMin);
                            cancha.GruposJugando.Add(nuevoGrupo);
                            this.contadores[indexProxEvento - 1]++;
                            if(nuevoGrupo.EsBasket())
                            {
                                Grupo otroGrupoBasket = this.cancha.ColaGrupos.Dequeue();
                                otroGrupoBasket.EmpezarJugar(this.relojMin);
                                this.cancha.GruposJugando.Add(otroGrupoBasket);
                                this.acumuladoresEspera[0] += this.relojMin - otroGrupoBasket.HoraLlegada;
                                this.contadores[0]++;
                            }
                            cancha.OcuparCancha();
                            this.eventos[indexProxEvento + 3].generarProximoEvento(this.relojMin);
                        }
                        else
                        {
                            cancha.ColaGrupos.Enqueue(nuevoGrupo);
                        }
                        break;

                    case 4:
                    case 5:
                    case 6:
                        //Caso fin de servicio
                        double tiempoOcupacion = this.relojMin - this.cancha.GruposJugando[0].TiempoComienzoJuego;
                        this.acumOcupacionCancha += tiempoOcupacion;
                        this.acumuladoresOcupacion[indexProxEvento - 4] += tiempoOcupacion;
                        this.cancha.SacarEquiposCancha();
                        this.cancha.AcondicionarCancha();
                        this.eventos[0].generarProximoEvento(this.relojMin);
                        break;
                }
            }

            //Retorno de los vectores estado persistentes para el form
            return vectoresEstadoPersistentes;
        }

        private int decidirProximoEvento()
        {
            int indexSigEvento = -1;
            double diferenciaTiempoMin = double.MaxValue, diferenciaTiempo;
            for(int i=0; i < this.eventos.Count; i++)
            {
                if(this.eventos[i].ProximoEvento != null) {
                    diferenciaTiempo = (double)this.eventos[i].ProximoEvento - this.relojMin;
                    if (diferenciaTiempo >= 0 && diferenciaTiempo < diferenciaTiempoMin)
                    {
                        diferenciaTiempoMin = diferenciaTiempo;
                        indexSigEvento = i;
                    }
                }
                
            }

            return indexSigEvento;
        }

        private bool buscarGrupoBasketEnCola(out Grupo encontrado)
        {
            encontrado = this.cancha.ColaGrupos.ToList().Find(grupo => grupo.EsBasket());
            return encontrado != null;
        }
    }
}
