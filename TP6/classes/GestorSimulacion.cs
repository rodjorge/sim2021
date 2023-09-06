﻿using System;
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
        private double relojMin;
        private object[] ultimoVectorEstado = new object[40];
        private List<Evento> eventos;
        private Cancha cancha;
        private int[] contadores;
        private double[] acumuladoresEspera;
        private double acumOcupacionCancha;

        uint lastNroCliente;
        Grupo.Disciplinas[] disciplinas = new Grupo.Disciplinas[] { Grupo.Disciplinas.Basketball, Grupo.Disciplinas.Futbol, Grupo.Disciplinas.Handball };

        public List<object[]> simular(double tiempo, int iteraciones, double[][] paramsEventos) => simular(tiempo, iteraciones, paramsEventos, -1, 0);
        public List<object[]> simular(double tiempo, int iteraciones, double[][] paramsEventos, double horaVerDesde, int iteracionesVerHasta)
        {
            //Inicializacion

            this.relojMin = 0;
            this.lastNroCliente = 0;
            this.contadores = new int[] { 0, 0, 0 };
            this.acumuladoresEspera = new double[] { 0, 0, 0 };
            this.acumOcupacionCancha = 0;

            this.cancha = new Cancha(1);

            this.eventos = new List<Evento>();
            Dictionary<Grupo.Disciplinas, double> D = new Dictionary<Grupo.Disciplinas, double>(3);
            D.Add(Grupo.Disciplinas.Basketball, paramsEventos[0][0]);
            D.Add(Grupo.Disciplinas.Futbol, paramsEventos[0][1]);
            D.Add(Grupo.Disciplinas.Handball, paramsEventos[0][2]);
            this.eventos.Add(new EventoFinAcondicionamientoCancha(paramsEventos[7][0], D));
            this.eventos.Add(new EventoLlegadaGrupoBasket(paramsEventos[1][0], paramsEventos[1][1]));
            this.eventos.Add(new EventoLlegadaGrupoFutbol(paramsEventos[2][0]));
            this.eventos.Add(new EventoLlegadaGrupoHandball(paramsEventos[3][0], paramsEventos[3][1]));
            this.eventos.Add(new EventoFinOcupacionCanchaBasket(paramsEventos[4][0], paramsEventos[4][1])); // Se generan 2 eventos de fin de ocupacion de basket distintos,
            this.eventos.Add(new EventoFinOcupacionCanchaBasket(paramsEventos[4][0], paramsEventos[4][1])); // uno para cada equipo que ocupe la cancha
            this.eventos.Add(new EventoFinOcupacionCanchaFutbol(paramsEventos[5][0], paramsEventos[5][1]));
            this.eventos.Add(new EventoFinOcupacionCanchaHandball(paramsEventos[6][0], paramsEventos[6][1]));

            //Generacion de tiempos de llegada
            this.eventos[1].generarProximoEvento();
            this.eventos[2].generarProximoEvento();
            this.eventos[3].generarProximoEvento();

            //Armado del primer vector estado
            this.ultimoVectorEstado[0] = "Inicializacion";
            this.ultimoVectorEstado[1] = this.relojMin;
            this.ultimoVectorEstado[2] = this.eventos[0].TiempoEntreEventos.ToString()?? "";
            this.ultimoVectorEstado[3] = this.eventos[0].ProximoEvento.ToString()?? "";
            int lastIndex = 3;
            foreach (Evento evento in this.eventos.Skip(1))
            {
                this.ultimoVectorEstado[lastIndex + 1] = evento.Random.ToString()?? "";
                if(evento.tieneDistribucionNormal())
                {
                    lastIndex++;
                    this.ultimoVectorEstado[lastIndex + 1] = (evento as EventoConNormal).Random2.ToString() ?? "";
                }
                this.ultimoVectorEstado[lastIndex + 2] = evento.TiempoEntreEventos.ToString()?? "";
                this.ultimoVectorEstado[lastIndex + 3] = evento.ProximoEvento.ToString()?? "";
                lastIndex += 3;
            }
            this.ultimoVectorEstado[29] = this.cancha.Estado.Nombre;
            this.ultimoVectorEstado[30] = this.cancha.ColaGrupos.Count;
            this.ultimoVectorEstado[31] = this.contadores[0];
            this.ultimoVectorEstado[32] = this.contadores[1];
            this.ultimoVectorEstado[33] = this.contadores[2];
            this.ultimoVectorEstado[34] = this.acumuladoresEspera[0];
            this.ultimoVectorEstado[35] = this.acumuladoresEspera[1];
            this.ultimoVectorEstado[36] = this.acumuladoresEspera[2];
            this.ultimoVectorEstado[37] = this.acumOcupacionCancha;

            this.ultimoVectorEstado[38] = new List<object[]>(); //El penúltimo indice del vector estado corresponde a una lista dinamica con datos de los grupos
            this.ultimoVectorEstado[39] = null; // El último indice del vector estado corresponde a la tabla de integracion númerica usada para obtener el tiempo de acondicionamiento

            iteraciones--;

            //Creacion de lista de vectores estado que seran almacenados y mostrados (incluyendo el último vector estado)
            List<object[]> vectoresEstadoPersistentes = new List<object[]>();

            //Si se quiere ver las filas desde que el reloj marca 0, se incluye tambien el vector de estado de inicializacion
            if(horaVerDesde == 0)
            {
                vectoresEstadoPersistentes.Add((object[])ultimoVectorEstado.Clone());
                iteracionesVerHasta--;
            }


            //Simulacion

            bool finPorReloj = false;
            int ultimaIterPersistente = -1;

            for (int i = 0; i < iteraciones; i++)
            {
                string strSubIndiceEvento = "";
                int indexProxEvento = this.decidirProximoEvento();
                this.relojMin = (double)this.eventos[indexProxEvento].ProximoEvento;

                //Elimina los datos que no deben arrastrarse de los eventos
                foreach (Evento evento in this.eventos)
                {
                    evento.borrarDatosTemporales();
                }

                //Chequeo de si la simulacion se pasó del tiempo limite ingresado
                if (tiempo < this.relojMin)
                {
                    this.ultimoVectorEstado[0] = "Fin de la simulación";
                    this.ultimoVectorEstado[1] = tiempo;

                    //Actualizacion solo de la parte de eventos
                    this.ultimoVectorEstado[2] = this.eventos[0].TiempoEntreEventos.ToString() ?? "";
                    this.ultimoVectorEstado[3] = this.eventos[0].ProximoEvento.ToString() ?? "";
                    lastIndex = 3;
                    foreach (Evento evento in this.eventos.Skip(1))
                    {
                        this.ultimoVectorEstado[lastIndex + 1] = evento.Random.ToString() ?? "";
                        if (evento.tieneDistribucionNormal())
                        {
                            lastIndex++;
                            this.ultimoVectorEstado[lastIndex + 1] = (evento as EventoConNormal).Random2.ToString() ?? "";
                        }
                        this.ultimoVectorEstado[lastIndex + 2] = evento.TiempoEntreEventos.ToString() ?? "";
                        this.ultimoVectorEstado[lastIndex + 3] = evento.ProximoEvento.ToString() ?? "";
                        lastIndex += 3;
                    }

                    vectoresEstadoPersistentes.Add(ultimoVectorEstado);
                    finPorReloj = true;
                    break;
                }

                switch (indexProxEvento)
                {
                    case 0:
                        //Caso acondicionamiento
                        this.eventos[indexProxEvento].borrarProximoEvento();
                        if (this.cancha.ColaGrupos.Count != 0)
                        {
                            //Se hace pasar al siguiente grupo de la cola
                            Grupo grupoPorPasar = this.cancha.ColaGrupos.Dequeue();
                            if (grupoPorPasar.EsBasket())
                            {
                                //Si el grupo por pasar es de basket, se busca en la cola otro grupo que sea de basket y se lo hace pasar
                                if (this.buscarGrupoBasketEnCola(out Grupo otroGrupoBasket))
                                {
                                    otroGrupoBasket.EmpezarJugar(this.relojMin);
                                    this.cancha.GruposJugando.Add(otroGrupoBasket);
                                    this.contadores[0] += 2;
                                    this.acumuladoresEspera[0] += this.relojMin - grupoPorPasar.HoraLlegada;
                                    this.acumuladoresEspera[0] += this.relojMin - otroGrupoBasket.HoraLlegada;
                                    // Al ocupar la cancha 2 grupos de basket se generar 2 eventos fin de servicio distintos
                                    this.eventos[4].generarProximoEvento(this.relojMin);
                                    this.eventos[5].generarProximoEvento(this.relojMin);
                                }
                                //Si no se encuentra otro grupo que sea de basket, se pone para pasar al siguiente grupo y se devuelve el de basket al frente de la cola
                                else
                                {
                                    Grupo grupoBasketRechazado = grupoPorPasar;
                                    if (this.cancha.ColaGrupos.Count != 0)
                                    {
                                        grupoPorPasar = this.cancha.ColaGrupos.Dequeue();
                                        this.cancha.ColaGrupos = new Queue<Grupo>(this.cancha.ColaGrupos.Prepend(grupoBasketRechazado));
                                    }
                                    else
                                    {
                                        this.cancha.ColaGrupos = new Queue<Grupo>(this.cancha.ColaGrupos.Prepend(grupoBasketRechazado));
                                        this.cancha.LiberarCancha();
                                        break;
                                    }
                                }
                            }

                            grupoPorPasar.EmpezarJugar(this.relojMin);
                            this.cancha.GruposJugando.Add(grupoPorPasar);
                            this.cancha.OcuparCancha();

                            if (grupoPorPasar.EsFutbol())
                            {
                                this.contadores[1]++;
                                this.acumuladoresEspera[1] += this.relojMin - grupoPorPasar.HoraLlegada;
                                this.eventos[6].generarProximoEvento(this.relojMin);
                            }
                            else if (grupoPorPasar.EsHandball())
                            {
                                this.contadores[2]++;
                                this.acumuladoresEspera[2] += this.relojMin - grupoPorPasar.HoraLlegada;
                                this.eventos[7].generarProximoEvento(this.relojMin);
                            }

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
                        Grupo nuevoGrupo = new Grupo(++this.lastNroCliente, this.disciplinas[indexProxEvento - 1], EsperandoCancha.Instancia, this.relojMin);
                        strSubIndiceEvento = "_" + this.lastNroCliente.ToString();
                        if (this.cancha.EstaLibre() && (!nuevoGrupo.EsBasket() || this.cancha.ColaGrupos.Count != 0 && this.cancha.ColaGrupos.Peek().EsBasket()))
                        {
                            nuevoGrupo.EmpezarJugar(this.relojMin);
                            this.cancha.GruposJugando.Add(nuevoGrupo);
                            this.contadores[indexProxEvento - 1]++;
                            if (nuevoGrupo.EsBasket())
                            {
                                Grupo otroGrupoBasket = this.cancha.ColaGrupos.Dequeue();
                                otroGrupoBasket.EmpezarJugar(this.relojMin);
                                this.cancha.GruposJugando.Add(otroGrupoBasket);
                                this.acumuladoresEspera[0] += this.relojMin - otroGrupoBasket.HoraLlegada;
                                this.contadores[0]++;
                                // Al ocupar la cancha 2 grupos de basket se generar 2 eventos fin de servicio distintos
                                this.eventos[4].generarProximoEvento(this.relojMin);
                                this.eventos[5].generarProximoEvento(this.relojMin);
                            }
                            else
                            {
                                this.eventos[indexProxEvento + 4].generarProximoEvento(this.relojMin);
                            }
                            cancha.OcuparCancha();
                        }
                        else
                        {
                            cancha.ColaGrupos.Enqueue(nuevoGrupo);
                        }
                        break;

                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        //Caso fin de servicio
                        this.eventos[indexProxEvento].borrarProximoEvento();
                        int indexGrupoASalir = 0;
                        if(indexProxEvento == 5 && this.eventos[4].ProximoEvento != null)
                        {
                            indexGrupoASalir = 1;   
                        }
                        else if(indexProxEvento != 4 || this.eventos[5].ProximoEvento == null)
                        {
                            this.cancha.AcondicionarCancha();
                            (this.eventos[0] as EventoFinAcondicionamientoCancha).generarProximoEvento(this.relojMin, cancha.ColaGrupos.Count,
                                                                                                        this.cancha.GruposJugando[indexGrupoASalir].Disciplina);
                        }
                        strSubIndiceEvento = "_" + this.cancha.GruposJugando[indexGrupoASalir].Numero.ToString();
                        double tiempoOcupacion = this.relojMin - this.cancha.GruposJugando[indexGrupoASalir].TiempoComienzoJuego;
                        this.acumOcupacionCancha += tiempoOcupacion;
                        this.cancha.SacarEquipoCancha(indexGrupoASalir);
                        break;
                }

                //Armado del vector estado
                this.ultimoVectorEstado[0] = this.eventos[indexProxEvento].ToString() + strSubIndiceEvento;
                this.ultimoVectorEstado[1] = this.relojMin;
                this.ultimoVectorEstado[2] = this.eventos[0].TiempoEntreEventos.ToString()?? "";
                this.ultimoVectorEstado[3] = this.eventos[0].ProximoEvento.ToString() ?? "";
                lastIndex = 3;
                foreach (Evento evento in this.eventos.Skip(1))
                {
                    this.ultimoVectorEstado[lastIndex + 1] = evento.Random.ToString() ?? "";
                    if (evento.tieneDistribucionNormal())
                    {
                        lastIndex++;
                        this.ultimoVectorEstado[lastIndex + 1] = (evento as EventoConNormal).Random2.ToString() ?? "";
                    }
                    this.ultimoVectorEstado[lastIndex + 2] = evento.TiempoEntreEventos.ToString() ?? "";
                    this.ultimoVectorEstado[lastIndex + 3] = evento.ProximoEvento.ToString() ?? "";
                    lastIndex += 3;
                }
                this.ultimoVectorEstado[29] = this.cancha.Estado.Nombre;
                this.ultimoVectorEstado[30] = this.cancha.ColaGrupos.Count;
                this.ultimoVectorEstado[31] = this.contadores[0];
                this.ultimoVectorEstado[32] = this.contadores[1];
                this.ultimoVectorEstado[33] = this.contadores[2];
                this.ultimoVectorEstado[34] = this.acumuladoresEspera[0];
                this.ultimoVectorEstado[35] = this.acumuladoresEspera[1];
                this.ultimoVectorEstado[36] = this.acumuladoresEspera[2];
                this.ultimoVectorEstado[37] = this.acumOcupacionCancha;

                //Creando lista de objetos temporales para asignarla al ultimo indice del vector estado
                List<object[]> listaEstadosObjTemp = new List<object[]>();
                foreach (Grupo grupoJugando in this.cancha.GruposJugando)
                {
                    object[] estadoGrupo = new object[] {
                        grupoJugando.Numero, //Numero y disciplina solo se usaran para los encabezados de columna
                        grupoJugando.Disciplina, // o eventualmente para un algoritmo que les asigne una columna fija
                        grupoJugando.Estado.Nombre,
                        grupoJugando.HoraLlegada,
                        grupoJugando.TiempoComienzoJuego
                    };
                    listaEstadosObjTemp.Add(estadoGrupo);
                }

                foreach (Grupo grupoEnCola in this.cancha.ColaGrupos.ToList())
                {
                    object[] estadoGrupo = new object[] {
                        grupoEnCola.Numero, //Numero y disciplina solo se usaran para los encabezados de columna
                        grupoEnCola.Disciplina, // o eventualmente para un algoritmo que les asigne una columna fija
                        grupoEnCola.Estado.Nombre,
                        grupoEnCola.HoraLlegada,
                        grupoEnCola.TiempoComienzoJuego
                    };
                    listaEstadosObjTemp.Add(estadoGrupo);
                }

                this.ultimoVectorEstado[38] = listaEstadosObjTemp;

                this.ultimoVectorEstado[39] = (this.eventos[0] as EventoFinAcondicionamientoCancha).ProcesoEuler;

                //Lógica de persistencia de vectores estado seleccionados
                if (this.relojMin >= horaVerDesde && iteracionesVerHasta > 0)
                {
                    iteracionesVerHasta--;
                    vectoresEstadoPersistentes.Add((object[])ultimoVectorEstado.Clone());
                    ultimaIterPersistente = i;
                }
            }

            //Si termina por iteraciones y el ultimo vector estado no fue persistente, se lo hace persistente
            if(!finPorReloj && ultimaIterPersistente < iteraciones-1)
            {
                vectoresEstadoPersistentes.Add((object[])ultimoVectorEstado.Clone());
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
            encontrado = null;
            List<Grupo> colaHechaLista = this.cancha.ColaGrupos.ToList();
            int indexEncontrado = colaHechaLista.FindIndex(grupo => grupo.EsBasket());
            if (indexEncontrado != -1)
            {
                encontrado = colaHechaLista[indexEncontrado];
                colaHechaLista.RemoveAt(indexEncontrado);
                this.cancha.ColaGrupos = new Queue<Grupo>(colaHechaLista);
            }
            return indexEncontrado != -1;
        }
    }
}
