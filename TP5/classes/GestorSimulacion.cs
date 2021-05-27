using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.eventos;
using TP5.classes.modelos.servidores;

namespace TP5.classes
{
    class GestorSimulacion
    {
        private double relojMin;
        private object[] ultimoVectorEstado = new object[34];
        private List<Evento> eventos;
        private Cancha cancha;
        private int contadorGruposBasket, contadorGruposFutbol, contadorGruposHandball;
        private double acumEsperaGruposBasket, acumEsperaGruposFutbol, acumEsperaGruposHandball;
        private double acumOcupacionCancha;
        private double acumOcupacionCanchaBasket, acumOcupacionCanchaFutbol, acumOcupacionCanchaHandball;

        public List<List<object>> simular(double tiempo, int iteraciones)
        {
            //Inicializacion
            this.relojMin = 0;
            contadorGruposBasket = contadorGruposFutbol = contadorGruposHandball = 0;
            acumEsperaGruposBasket = acumEsperaGruposFutbol = acumEsperaGruposHandball = 0;
            acumOcupacionCancha = 0;
            acumOcupacionCanchaBasket = acumOcupacionCanchaFutbol = acumOcupacionCanchaHandball = 0;

            //Simulacion
        }
    }
}
