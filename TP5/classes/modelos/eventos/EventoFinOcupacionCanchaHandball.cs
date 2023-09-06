﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes.modelos.eventos
{
    class EventoFinOcupacionCanchaHandball : Evento
    {
        private double media, desviacion;

        public EventoFinOcupacionCanchaHandball(double media, double desviacion)
        {
            this.media = media;
            this.desviacion = desviacion;
        }

        public override double generarTiempoEntreEventos()
        {
            return this.generador.generarVariableNormal(this.media, this.desviacion)[0];
        }

        public override string ToString()
        {
            return "Fin_ocupacion_cancha_handball";
        }
    }
}
