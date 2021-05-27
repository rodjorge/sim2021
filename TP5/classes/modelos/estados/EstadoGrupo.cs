using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.classes.modelos.clientes;

namespace TP5.classes.modelos.estados
{
    abstract class EstadoGrupo:Estado
    {
        public abstract void EsperarCancha(Grupo grupo);
        public abstract void EmpezarAJugar(Grupo grupo);

        public abstract bool EsEsperandoCancha();
        public abstract bool EsJugando();
    }
}
