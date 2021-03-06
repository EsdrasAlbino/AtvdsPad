using System;
using System.Collections.Generic;
using System.Text;

namespace AtvdGersonDiagram
{
    public class Sala
    {
        private PortaDaSala portaEntrada;
        private float metragemQuadrada;
        private Porta portaAuxiliar;

        public Sala(PortaDaSala portaEntrada, float metragemQuadrada, Porta portaAuxiliar)
        {
            this.PortaEntrada = portaEntrada;
            this.MetragemQuadrada = metragemQuadrada;
            this.PortaAuxiliar = portaAuxiliar;
        }

        public PortaDaSala PortaEntrada { get => portaEntrada; set => portaEntrada = value; }

        public float MetragemQuadrada { get => metragemQuadrada; set => metragemQuadrada = value; }

        public Porta PortaAuxiliar { get => portaAuxiliar; set => portaAuxiliar = value; }
    }
}
