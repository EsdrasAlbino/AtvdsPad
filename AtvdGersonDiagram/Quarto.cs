using System;
using System.Collections.Generic;
using System.Text;

namespace AtvdGersonDiagram
{
    public class Quarto
    {
        private PortaQuarto porta;
        private bool banheiro;
        private float metragemQuadrada;

        public Quarto(PortaQuarto porta, bool banheiro, float metragemQuadrada)
        {
            this.porta = porta;
            this.banheiro = banheiro;
            this.metragemQuadrada = metragemQuadrada;
        }

        public PortaQuarto Porta { get => porta; set => porta = value; }
        public bool Banheiro { get => banheiro; set => banheiro = value; }
        public float MetragemQuadrada { get => metragemQuadrada; set => metragemQuadrada = value; }
    }
}
